using Microsoft.AspNetCore.Mvc;

namespace DungeonWiki.Controllers.wiki
{
    [ApiController]
    [Route("wiki")]
    public class PageController : Controller
    {
        [HttpGet("{pageName}")]
        public IActionResult GetPage(string pageName)
        {
            return Ok($"Content of the wiki page: {pageName}");
        }
    }
}
