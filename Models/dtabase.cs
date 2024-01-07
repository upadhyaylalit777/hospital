using System.ComponentModel.DataAnnotations;

namespace hospital.Models
{
    public class dtabase { 
    

        public int id { get; set; }
        [Required]
        public string? name { get; set; }
        public string? description { get; set; }
    }
}
