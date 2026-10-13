using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StatusCodeEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAPIController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult GetStatus(int id)
        {
            switch (id)
            {
                case 1:
                    return Created(); //204
                    break;
                case 2:
                    return NotFound();
                    break;
                case 3:
                    return Unauthorized();
                    break;
                case 4:
                    return Content("abcd");
                    break;
                default:
                    return BadRequest();
                    break;
            }
        }
    }
}
