using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSB.API.Models
{
    public class V_IPD
    {
        [Key]
        public string AN { get; set; }
        public string HN { get; set; }
        public string Fullname { get; set; }
        public string FullAge { get; set; }
        public DateTime AdmDateTime { get; set; }
        public DateTime DischargeDateTime { get; set; }
        public string DefaultRightCode { get; set; }
        public string DefaultRightName { get; set; }
        public string ActiveWard { get; set; }
        public string ActiveWardName { get; set; }
        public int DiagnosisStatusType { get; set; }
        public string DiagnosisStatusTypeName { get; set; }
        public string DischargeCode { get; set; }
        public string DischargeName { get; set; }
        public string DischargeDoctor { get; set; }
        public string DischargeDoctorName { get; set; }
        public int? Los { get; set; }
    }
}
