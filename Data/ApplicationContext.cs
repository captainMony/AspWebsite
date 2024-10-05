using Microsoft.EntityFrameworkCore;
using SoftUniSpaceConsoleWebApp.Data.Entities;


namespace SoftUniSpaceConsoleWebApp.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Crew> Crewmen {  get; set; } //Its CrewMEN cuz plural? && From here we interact with database? Read,Delete,Create...

      
        public DbSet<Cargo> Cargo { get; set; } 

        public ApplicationContext(DbContextOptions<ApplicationContext>options) 
            :base(options)
        { }

    }
}

