using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TDBlog.Api.Controllers
{
    [Route("api/test")]
    [ApiController]
    [Authorize]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult TestAuthen()
        {
            return Ok();
        }
    }
}
