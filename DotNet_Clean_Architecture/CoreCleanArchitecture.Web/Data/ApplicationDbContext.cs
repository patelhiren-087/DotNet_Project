using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoreCleanArchitecture.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // If ProjectViewModel is used for querying data, you can define it here as a keyless entity.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Specify that ProjectViewModel is a keyless entity
            modelBuilder.Entity<ProjectViewModel>()
                .HasNoKey();

            // Additional model configurations can go here
        }
    }
}
