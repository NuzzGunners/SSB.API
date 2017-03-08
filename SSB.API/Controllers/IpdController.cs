using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SSB.API.Models;
using System.Collections;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SSB.API.Controllers
{
    [Route("api/[controller]")]
    public class IpdController : Controller
    {
        DNHOSContext context = new DNHOSContext();

        [HttpGet("{query}")]
        public IActionResult GetById(string query)
        {
            var item = context.V_IPD.Where(i => i.AN == query);
            return new OkObjectResult(item);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
