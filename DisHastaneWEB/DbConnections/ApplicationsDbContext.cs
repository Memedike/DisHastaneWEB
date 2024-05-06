using DisHastaneWEB.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace DisHastaneWEB.DbConnections
{
    public class ApplicationsDbContext : DbContext
    {
        public ApplicationsDbContext(DbContextOptions<ApplicationsDbContext> options) : base(options)
        {

        }

        public DbSet<Slider>? Sliders { get; set; }

    }
}
