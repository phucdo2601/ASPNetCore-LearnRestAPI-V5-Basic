using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LearnEnityFrameGenBaseDataB01.Models
{
    public class EmployeeDbContext : DbContext
    {

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
                
        }

        public DbSet<EmployeeModel> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel
            {
                Id = 1,
                FirstName = "Uncle",
                LastName = "Bob",

            }, new EmployeeModel
            {
                Id = 2,
                FirstName = "Jan",
                LastName = "Kirsten",

            });
        }
    }
}
