using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace EmployeeManagementSystem.Entity.Models
{
    public class Employee
    {
        
         public int? EmpID { set; get; }
        [Required(ErrorMessage ="Employee Name is required ")]
         public string? EmpName { set; get; }

        [Required(ErrorMessage = "Employee Salery is required ")]
        public double Salery { set; get; }
         
        public Address? address { set; get; }

    }
}
