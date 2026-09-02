using Microsoft.EntityFrameworkCore;
using PortfolioCore.Entities;

namespace PortfolioCore.Context
{
    public class PortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PM6PHLL\\SQLEXPRESS;initial Catalog=PortfolioNightDb;integrated Security=True;TrustServerCertificate=True;");
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public  DbSet<Message> Messages { get; set; }
        public  DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<WorkArea> WorkAreas { get; set; }
        public DbSet <About>Abouts { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<Service>  Services { get; set; }
        
    }
}
