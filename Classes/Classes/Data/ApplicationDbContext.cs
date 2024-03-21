using courseunits.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace courseunits.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //add some tabels to DB
        public DbSet<Students> students { get; set; }
        public DbSet<Profesers> profesers { get; set; }
        public DbSet<Appusers> AppUsers { get; set; }
        public DbSet<Classes> Classes { get; set; }
        

    }
}