using Microsoft.EntityFrameworkCore;
using Disaster_Management;
using Disaster_Management.Models;
namespace Disaster_Management
{
    public class ApplicationDbContext :DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<DisasterViewModel> Disasters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   

            modelBuilder.Entity<DisasterViewModel>(x =>
            {
                x.ToTable("Disaster");
                x.HasKey(e => e.id);
                x.Property(e => e.category).IsRequired();
                x.Property(e => e.severity).IsRequired();
                x.Property(e => e.location).IsRequired(false);
                x.Property(e => e.date_occoured).IsRequired();

            });



            base.OnModelCreating(modelBuilder);
        }

    }
}
