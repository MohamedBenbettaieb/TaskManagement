using Microsoft.EntityFrameworkCore;
using TaskManagementService.Models;

namespace TaskManagementService.Data
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options) { }
        
        public DbSet<Company> CompaniesTable { get; set; }
        public DbSet<User> UsersTable { get; set; }

    }
}
