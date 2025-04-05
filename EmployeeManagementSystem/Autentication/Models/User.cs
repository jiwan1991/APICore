using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Autentication.Models
{
    public class User
    {
        [Required]
        public string ?UserName { set; get; }

        [Required]
        public string ?Password { set; get; }
    }
}
