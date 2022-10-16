using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Labb2Angular.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [AllowNull]
        public string DepartmentName { get; set; }
        [AllowNull]
        public string Description { get; set; }
        [AllowNull]
        public List<Employee> Employees { get; set; }
        
    }
}
