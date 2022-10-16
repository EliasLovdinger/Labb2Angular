using Labb2Angular.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace Labb2Angular.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }


        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(new Department
            { DepartmentId = 1, DepartmentName = "Economy", Description = "Handles the companies invoices and invoicing" });

            modelBuilder.Entity<Department>().HasData(new Department
            { DepartmentId = 2, DepartmentName = "Marketing", Description = "Markets our product" });

            modelBuilder.Entity<Department>().HasData(new Department
            { DepartmentId = 3, DepartmentName = "It", Description = "Fixes your computer when it breaks" });

            modelBuilder.Entity<Department>().HasData(new Department
            { DepartmentId = 4, DepartmentName = "Support", Description = "Help our customers to understand that they are wrong" });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Kalle",
                LastName = "Anka",
                Email = "kalle@anka.se",
                MobileNumber = "01231244",
                Gender = "Anka",
                Adress = "Gata1231235",
                Salary = 77777,
                DepartmentId = 1

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Knatte",
                LastName = "Anka",
                Email = "knatte@anka.se",
                MobileNumber = "401243124",
                Gender = "Anka",
                Adress = "Gata1231415",
                Salary = 54233,
                DepartmentId = 2

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Tjatte",
                LastName = "Anka",
                Email = "tjatte@anka.se",
                MobileNumber = "1337411",
                Gender = "Anka",
                Adress = "Gata3132",
                Salary = 27777,
                DepartmentId = 3

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Fnatte",
                LastName = "Anka",
                Email = "Fnatte@Hotmail.com",
                MobileNumber = "12312313",
                Gender = "Anka",
                Adress = "Gata51231",
                Salary = 25555,
                DepartmentId = 4

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 5,
                FirstName = "Latte",
                LastName = "Anka",
                Email = "Latte@Hotmail.com",
                MobileNumber = "123124667",
                Gender = "Anka",
                Adress = "Gata5123123121",
                Salary = 25552,
                DepartmentId = 1

            });
        }
    }
}
