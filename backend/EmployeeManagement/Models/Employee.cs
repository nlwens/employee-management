using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { set; get; }

        [Required(ErrorMessage = "First name is required!")]
        // [Length(0,50)]
        public string FirstName { set; get; }
        
        [Required(ErrorMessage = "Last name is required!")]
        public string LastName { set; get; }
        
        [Required(ErrorMessage = "Phone number is required!")]
        // [Range(0, 100000)]
        public string Phone {  set; get; }
        
        [Required(ErrorMessage = "E-mail number is required!")]
        [EmailAddress(ErrorMessage = "Invalid e-mail address!")]
        public string Email { set; get; }
        
        [Required(ErrorMessage = "Position is required!")]
        public string Position { set; get; }

    }
}
