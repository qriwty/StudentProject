using StudentProjectAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace StudentProjectAPI.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
