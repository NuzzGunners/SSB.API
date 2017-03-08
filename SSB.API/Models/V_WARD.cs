using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSB.API.Models
{
    public class V_WARD
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
