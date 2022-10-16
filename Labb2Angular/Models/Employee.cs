using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Labb2Angular.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Please enter First name!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last name!")]
        public string LastName { get; set; }


        public string FullName => FirstName +" "+ LastName;


        [Required(ErrorMessage = "Please enter Email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Mobile number!")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Please enter Gender!")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter Adress!")]
        public string Adress { get; set; }


        [Required(ErrorMessage = "Please enter Salary!")]
        public int Salary { get; set; }
        

        [Required(ErrorMessage = "Please enter a departmentId")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
