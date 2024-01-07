
using Microsoft.Build.Framework;
using System.ComponentModel;

namespace hospital.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Patient Name")]
       
        public string PatientName { get; set; }

        [Required]
        [DisplayName("Patient Age")]
        public int PatientAge { get; set; }

        [Required]
        [DisplayName("E-mail Id:")]
        public string Pemail { get; set; }

        [Required]
        [DisplayName("Doctor Name")]
        public string Dname { get; set; }

        [Required]
        [DisplayName("Contact No:")]
        public int Cno { get; set; }

        [Required]
        [DisplayName("Appointment Date And Time slot")]
        public string ApDate { get; set; }
    }
}
