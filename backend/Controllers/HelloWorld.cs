using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorld : ControllerBase
    {
        [HttpGet("/api/hello")]  // This now effectively maps to GET /demo
        public ActionResult<string> GetDemo()
        {
            return "Hello World";
        }
    }
}
