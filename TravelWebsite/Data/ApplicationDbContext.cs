using Microsoft.EntityFrameworkCore;
using TravelWebsite.Models;

namespace TravelWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CompanyModel> Company { get; set; }

        public DbSet<ContactModel> Contact { get; set; }

        public DbSet<DestinationsModel> Destinations { get; set; }

        public DbSet<ToursModel> Tours { get; set; }

    }
}
