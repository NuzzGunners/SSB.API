using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SSB.API.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SSB.API.Controllers
{
    [Route("api/[controller]")]
    public class NurseController : Controller
    {
        DNHOSContext context = new DNHOSContext();

        [HttpGet]
        public IActionResult GetAll(string query)
        {
            var item = context.V_NURSE.Select(i => new { i.Code, i.Name }).ToArray();

            var dictionary = new Dictionary<string, object>();
            for (int i = 0; i < item.Length; i++)
            {
                dictionary.Add(string.Format("{0} : {1}", item[i].Code, item[i].Name), null);
            }

            List<dataNurse> listdataNurse = new List<dataNurse>();
            dataNurse objdataNurse = new dataNurse();
            objdataNurse.data = dictionary;
            listdataNurse.Add(objdataNurse);
            return new OkObjectResult(listdataNurse);
        }

        [HttpGet("{query}")]
        public IActionResult GetById(string query)
        {
            var item = context.V_NURSE.Find(query);
            if (item == null)
            {
                return NotFound();
            }
            return new OkObjectResult(item);
        }

        public class dataNurse
        {
            public object data { get; set; }
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
