using LinkShortener.Data.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LinkShortener.Controllers.V1
{
    [Route(ApiRoutes.V1.Test.Controller)]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet(ApiRoutes.V1.Test.Controller)]
        public async Task<IActionResult> Get()
        {
            return Ok(new { Test = "test" });
        }
    }
}
