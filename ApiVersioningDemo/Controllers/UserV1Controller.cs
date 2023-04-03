using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemo.Controllers
{
    [Route("api/user/[action]")]
    [ApiController]
    [ApiVersion("1")]
    public class UserV1Controller : ControllerBase
    {
        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok("Get user data");
        }
    }
}
