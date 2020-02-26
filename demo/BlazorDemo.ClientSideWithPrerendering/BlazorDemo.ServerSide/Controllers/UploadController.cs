using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlazorDemo.ServerSide {
    public class ChunkMetadata {
        public int Index { get; set; }
        public int TotalCount { get; set; }
        public int FileSize { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileGuid { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public UploadController(IWebHostEnvironment hostingEnvironment) {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        [Route("UploadFile")]
        public ActionResult UploadFile(IFormFile myFile) {
            try {
                var path = Path.Combine(_hostingEnvironment.ContentRootPath, "uploads");
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                using (var fileStream = System.IO.File.Create(Path.Combine(path, myFile.FileName))) {
                    myFile.CopyTo(fileStream);
                }
            } catch {
                Response.StatusCode = 400;
            }

            return new EmptyResult();
        }

        [HttpPost]
        [Route("UploadImage")]
        public ActionResult UploadImage(IFormFile myFile) {
            try {
                string[] imageExtensions = { ".jpg", ".jpeg", ".gif", ".png" };

                var fileName = myFile.FileName.ToLower();
                var isValidExtenstion = imageExtensions.Any(ext => {
                    return fileName.LastIndexOf(ext) > -1;
                });

                if(isValidExtenstion) {
                    var path = Path.Combine(_hostingEnvironment.ContentRootPath, "uploads");
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    using (var fileStream = System.IO.File.Create(Path.Combine(path, myFile.FileName))) {
                        myFile.CopyTo(fileStream);
                    }
                }
            } catch {
                Response.StatusCode = 400;
            }

            return new EmptyResult();
        }

        [HttpPost]
        [Route("UploadChunkFile")]
        public ActionResult UploadChunkFile(IFormFile myFile) {
            string chunkMetadata = Request.Form["chunkMetadata"];
            var tempPath = Path.Combine(_hostingEnvironment.ContentRootPath, "uploads");
            // Removes temporary files
            RemoveTempFilesAfterDelay(tempPath, new TimeSpan(0, 5, 0));

            try {
                if (!string.IsNullOrEmpty(chunkMetadata)) {
                    var metaDataObject = JsonConvert.DeserializeObject<ChunkMetadata>(chunkMetadata);

                    var tempFilePath = Path.Combine(tempPath, metaDataObject.FileGuid + ".tmp");
                    if (!Directory.Exists(tempPath))
                        Directory.CreateDirectory(tempPath);

                    AppendChunkToFile(tempFilePath, myFile);

                    if (metaDataObject.Index == (metaDataObject.TotalCount - 1))
                        SaveUploadedFile(tempFilePath, metaDataObject.FileName);
                }
            } catch {
                return BadRequest();
            }
            return Ok();
        }
        void AppendChunkToFile(string path, IFormFile content) {
            using(var stream = new FileStream(path, FileMode.Append, FileAccess.Write)) {
                content.CopyTo(stream);
            }
        }
        void SaveUploadedFile(string tempFilePath, string fileName) {
            var path = Path.Combine(_hostingEnvironment.ContentRootPath, "uploads");
            System.IO.File.Copy(tempFilePath, Path.Combine(path, fileName));
        }
        void RemoveTempFilesAfterDelay(string path, TimeSpan delay) {
            var dir = new DirectoryInfo(path);
            if(dir.Exists)
                foreach(var file in dir.GetFiles("*.tmp").Where(f => f.LastWriteTimeUtc.Add(delay) < DateTime.UtcNow))
                    file.Delete();
        }
    }
}
