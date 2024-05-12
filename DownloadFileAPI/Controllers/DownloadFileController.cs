using Microsoft.AspNetCore.Mvc;


namespace DownloadFileAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DownloadFileController : Controller
    {
        private readonly ILogger<DownloadFileController> _logger;

        public DownloadFileController(ILogger<DownloadFileController> logger)
        {
            _logger = logger;
        }

        [HttpGet("download")]
        public IActionResult Download()
        {
            var filepath = Path.Combine("images", "Image1.png");
            return File(System.IO.File.ReadAllBytes(filepath), "image/png", System.IO.Path.GetFileName(filepath));
        }
    }
}

