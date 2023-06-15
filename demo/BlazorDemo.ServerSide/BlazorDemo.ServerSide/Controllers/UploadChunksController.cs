using BlazorDemo.Data;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace BlazorDemo.AspNetCoreHost;

[Route("api/[controller]")]
[ApiController]
public class UploadChunksController : ControllerBase {
    [HttpPost("[action]")]
    public ActionResult Upload(IFormFile myFile) {
        string chunkMetadata = Request.Form["chunkMetadata"];
        try {
            if(!string.IsNullOrEmpty(chunkMetadata)) {
                var metaDataObject = JsonSerializer.Deserialize<ChunkMetadata>(chunkMetadata);
                // Write code that appends the 'myFile' file chunk to the temporary file.
                // You can use the $"{metaDataObject.FileGuid}.tmp" name for the temporary file.
                // Don't rely on or trust the FileName property without validation.

                if(metaDataObject.Index == metaDataObject.TotalCount - 1) {
                    // Write code that saves the 'myFile' file.
                    // Don't rely on or trust the FileName property without validation.
                }
            }
        } catch {
            return BadRequest();
        }
        return Ok();
    }
}
