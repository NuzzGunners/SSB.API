using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSB.API.Models
{
    public class V_SSBACCOUNT
    {
        [Key]
        public string Userid { get; set; }
        public string Fullname { get; set; }
    }
}
