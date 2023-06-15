using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace BlazorDemo.AspNetCoreHost;

[Route("api/[controller]")]
[ApiController]
public class UploadValidationController : ControllerBase {
    const long MaxFileSize = 4_000_000;
    readonly string[] imageExtensions = { ".JPG", ".JPEG", ".GIF", ".PNG" };
    [HttpPost("[action]")]
    public ActionResult Upload(IFormFile myFile) {
        try {
            var extension = Path.GetExtension(myFile.FileName).ToUpperInvariant();
            var isValidExtenstion = imageExtensions.Contains(extension);
            var isValidSize = myFile.Length <= MaxFileSize;

            if(!isValidExtenstion || !isValidSize)
                throw new InvalidOperationException();

            // Write code that saves the 'myFile' file.
            // Don't rely on or trust the FileName property without validation.
        } catch {
            return BadRequest();
        }
        return Ok();
    }
}
