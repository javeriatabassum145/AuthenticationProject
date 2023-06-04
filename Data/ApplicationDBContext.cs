using AuthenticationProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationProject.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) {}

        public DbSet<ApplicationUser> ApplicationUser {get;set;}
    }
}
