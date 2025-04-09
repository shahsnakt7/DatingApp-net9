using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<AppUser> Users { get; set; } // Ensure DbSet is correctly defined here
    }
}
// public class DataContext : DbContext
// {
//     public DataContext(DbContextOptions<DataContext> options)
//         : base(options)
//     {
//         // public DbSet<AppUser> Users { get; set; }
//     }
// }