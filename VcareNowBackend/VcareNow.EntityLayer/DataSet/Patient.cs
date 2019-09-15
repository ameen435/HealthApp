using System;
using System.Collections.Generic;
using System.Text;

namespace VcareNow.EntityLayer.DataSet
{
    public class Patient
    {
        public Guid PatientId { get; set; }
        public int PatientNumber { get; set; }
        public string PatientName { get; set; }
        public int PatientSsn { get; set; }
        public List<PatientInsurance> PatientInsurance { get; set; }
    }
}
