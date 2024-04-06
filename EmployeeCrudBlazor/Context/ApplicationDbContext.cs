
using EmployeeCrudBlazor.Models;
using Microsoft.EntityFrameworkCore;
namespace EmployeeCrudBlazor.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Models.ToDo> Employees { get; set; }
    }
}