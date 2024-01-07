using hospital.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;

namespace hospital.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        
     
        public DbSet<DocDb> Docs { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Doctors>  docts{ get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                 modelBuilder.Entity<DocDb>().HasData(
                new DocDb { id = 1, name = " Arun Kumar", description = "cardiologist" ,FEES=2000},
                new DocDb { id = 2, name = " Venugopal Iyer", description = "dentist", FEES = 1500 },
                new DocDb { id = 3, name = "steve rogers", description = "General Physician", FEES = 800 },
                new DocDb { id = 4, name = "Dr.Krishna Vasudev ", description = "Emergency OPD", FEES = 2500 },
                new DocDb { id = 5, name = "Dr.Tony Stark ", description = "Dean", FEES = 3000 },
                new DocDb { id = 6, name = "Dr.Natasha Ramonoff ", description = "Urologist", FEES = 500 },
                new DocDb { id = 7, name = "Dr.Thor Odinson ", description = "Neurologist", FEES = 800 },
                new DocDb { id = 8, name = "Dr.Bruce Banner ", description = "physic", FEES = 600 },
                 new DocDb { id = 9, name = "Dr.Bruce Bannen ", description = "gymasic", FEES = 400 }

                );
            modelBuilder.Entity<Book>().HasData(
                new Book { Id=1,PatientName="john",PatientAge=10,Cno=2000,Dname="ppp",Pemail="cyoh",ApDate="12-12-2003"}
            

            );
            modelBuilder.Entity<Doctors>().HasData(
                new Doctors { id = 1, name = " Arun Kumar", description = "cardiologist" ,FEES = 2000},
                new Doctors { id = 2, name = " Venugopal Iyer", description = "dentist", FEES = 1500 }
                );


        }

        
       
        

    }
}
