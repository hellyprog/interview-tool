using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InterviewTool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetChapters()
        {
            return default;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetChapter(int id)
        {
            return default;
        }

        [HttpPost]
        public async Task<IActionResult> CreateChapter()
        {
            return default;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateChapter()
        {
            return default;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveChapter(int id)
        {
            return default;
        }
    }
}
