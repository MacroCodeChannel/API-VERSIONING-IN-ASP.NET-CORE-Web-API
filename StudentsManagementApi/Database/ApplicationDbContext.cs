using Microsoft.EntityFrameworkCore;
using StudentsManagementApi.Models;

namespace StudentsManagementApi.Database
{
    public class ApplicationDbContext :DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
