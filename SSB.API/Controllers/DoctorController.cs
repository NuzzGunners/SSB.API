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
    public class DoctorController : Controller
    {
        DNHOSContext context = new DNHOSContext();

        [HttpGet]
        public IActionResult GetAll(string query)
        {
            var item = context.V_DOCTOR.Select(i => new { i.Doctor, i.Fullname }).ToArray();

            var dictionary = new Dictionary<string, object>();
            for (int i = 0; i < item.Length; i++)
            {
                dictionary.Add(string.Format("{0} : {1}",item[i].Doctor,item[i].Fullname), null);
            }

            List<dataDoctor> listdataDoctor = new List<dataDoctor>();
            dataDoctor objdataDoctor = new dataDoctor();
            objdataDoctor.data = dictionary;
            listdataDoctor.Add(objdataDoctor);
            return new OkObjectResult(listdataDoctor);
        }

        [HttpGet("{query}")]
        public IActionResult GetById(string query)
        {
            var item = context.V_DOCTOR.Find(query);
            if (item == null)
            {
                return NotFound();
            }
            return new OkObjectResult(item);
        }

        public class dataDoctor
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
