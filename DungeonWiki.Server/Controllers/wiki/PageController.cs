using Microsoft.AspNetCore.Mvc;

namespace DungeonWiki.Controllers.wiki
{
    [ApiController]
    [Route("wiki-api")]
    public class PageController : Controller
    {
        [HttpGet("{pageName}")]
        public IActionResult GetPage(string pageName)
        {
            return Ok($"page-api for {pageName}");
        }
    }
}
