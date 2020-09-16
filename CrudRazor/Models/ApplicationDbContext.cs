using Microsoft.EntityFrameworkCore;

namespace CrudRazor.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //public DbSet<Course> Courses { get; set; }
    }
}