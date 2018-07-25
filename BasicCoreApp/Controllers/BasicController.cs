using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicCoreApp.Controllers
{
    
    
    public class BasicController : Controller
    {
        [HttpGet]
        [Route("api/basicApp")]
        public IActionResult App()
        {
            return Ok("Basic DotNet Core Application");
        }
    }
}