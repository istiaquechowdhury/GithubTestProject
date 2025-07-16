using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GithubTestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public IActionResult Create()
        {
            return Ok();
        }
    }
}
