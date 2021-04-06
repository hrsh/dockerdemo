using Microsoft.AspNetCore.Mvc;

namespace dockerdemo.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok("Api.v1.Home");
        }
    }
}