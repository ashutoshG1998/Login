using Login.Models;
using Microsoft.EntityFrameworkCore;

namespace Login.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> permissions { get; set; }

        public DbSet<UserRole> userRoles {get;set;}



    }

}
