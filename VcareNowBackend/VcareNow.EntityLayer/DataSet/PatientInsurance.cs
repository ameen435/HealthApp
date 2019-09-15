using System;
using System.Collections.Generic;
using System.Text;

namespace VcareNow.EntityLayer.DataSet
{
    public class PatientInsurance
    {
        public string InsuranceName { get; set; }
        public Guid InsuranceId { get; set; }
        public string InsuranceDescription { get; set; }
    }
}
