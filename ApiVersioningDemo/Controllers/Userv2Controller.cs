using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemo.Controllers
{
    //Route for URI versioning
    [Route("api/v{version:apiVersion}/user/[action]")]
    //[Route("api/user/[action]")]
    [ApiController]
    [ApiVersion("2")]
    public class Userv2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            return Ok("Get User data from v2 controller");
        }
    }
}
