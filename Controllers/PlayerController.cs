using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eliq_developer_test.Models;
using Microsoft.AspNetCore.Mvc;

namespace eliq_developer_test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        private static Player soccer = new Player();
        [HttpGet    ]
        public IActionResult Get() {
            return Ok(soccer);
        }
    }
}