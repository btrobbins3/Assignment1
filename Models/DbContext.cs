using Microsoft.EntityFrameworkCore;

namespace Assignment1.Models
{
    public class Assignment1DbContext : DbContext 
    {
        public Assignment1DbContext (DbContextOptions<Assignment1DbContext> options)
			: base(options)
		{
		}
        
        public DbSet<Client> Clients {get; set;}
        public DbSet<Member> Members {get; set;}
        public DbSet<Project> Projects {get; set;}
        public DbSet<Team> Teams {get; set;}
    }
}