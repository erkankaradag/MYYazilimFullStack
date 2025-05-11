using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Context
{
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HURGENC\\SQLEXPRESS;Initial Catalog=PortfolioDayDb;Integrated Security=True;TrustServerCertificate=True;");

        }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set;}
        public DbSet<Skill> Skills { get; set; }
    }
}
