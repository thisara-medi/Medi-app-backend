using PMS.Core.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Models
{
    public class PatientRecord
    {
        public int Id { get; set; }

        public string Bht { get; set; }

        public PatientCategories  PatientCategories { get; set; }  

        public int Age { get; set; }

        public string Name { get; set; }

        public double Weight  { get; set; }

        public double Height { get; set; }

    }
}
