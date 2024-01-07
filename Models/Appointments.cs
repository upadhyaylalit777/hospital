using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace hospital.Models
{
    public class Appointments

    {
        [Key]
        public int id { get; set; }
        
        [DisplayName("Patient Name")]
        public String? PatientName { get; set; }

        [DisplayName("Age")]
        public String? PatientAge { get; set;}
    }
}
