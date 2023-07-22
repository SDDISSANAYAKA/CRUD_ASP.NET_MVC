using EmployeeData.Models.DBEntities;
using Microsoft.EntityFrameworkCore;


namespace EmployeeData.DAL
{
    public class EmployeeDBContext : DbContext
    {
        //Constructor
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {

        }

        //Data set for Employee class
        public DbSet<Employee> Employees { get; set; } 
    }
}
