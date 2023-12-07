using ASPNETWebAPIProjectTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETWebAPIProjectTemplate.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new ResponseModel
            {
                StatusCode = 200,
                Message = "Hello World!"
            });
        }

    }
}
