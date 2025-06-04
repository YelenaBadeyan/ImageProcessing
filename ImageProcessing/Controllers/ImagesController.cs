using ImageProcessing.Models;
using ImageProcessing.Services;
using Microsoft.AspNetCore.Mvc;

namespace ImageProcessing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly ImageProcessor _processor;

        public ImagesController(ImageProcessor processor)
        {
            _processor = processor;
        }

        [HttpPost("process")]
        public IActionResult ProcessImages([FromBody] List<ImageRequest> images)
        {
            var results = images.Select(_processor.ProcessImage).ToList();
            return Ok(results);
        }
    }
}
