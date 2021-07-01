using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.AspNetCoreHost {
    public class ChunkMetadata {
        public int Index { get; set; }
        public int TotalCount { get; set; }
        public int FileSize { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileGuid { get; set; }
    }

    public partial class UploadController : ControllerBase {
        [HttpPost("[action]")]
        public ActionResult UploadChunkFile(IFormFile myFile) {
            string chunkMetadata = Request.Form["chunkMetadata"];
            var tempPath = Path.Combine(ContentRootPath, "uploads");
            // Removes temporary files
            RemoveTempFilesAfterDelay(tempPath, new TimeSpan(0, 5, 0));

            try {
                if(!string.IsNullOrEmpty(chunkMetadata)) {
                    var metaDataObject = JsonSerializer.Deserialize<ChunkMetadata>(chunkMetadata);

                    var tempFilePath = Path.Combine(tempPath, metaDataObject.FileGuid + ".tmp");
                    if(!Directory.Exists(tempPath))
                        Directory.CreateDirectory(tempPath);

                    AppendChunkToFile(tempFilePath, myFile);

                    if(metaDataObject.Index == (metaDataObject.TotalCount - 1))
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
            var path = GetOrCreateUploadFolder();
            System.IO.File.Copy(tempFilePath, Path.Combine(path, fileName));
        }
        void RemoveTempFilesAfterDelay(string path, TimeSpan delay) {
            var dir = new DirectoryInfo(path);
            if(dir.Exists) {
                foreach(var file in dir.GetFiles("*.tmp").Where(f => f.LastWriteTimeUtc.Add(delay) < DateTime.UtcNow))
                    file.Delete();
            }
        }
    }
}
