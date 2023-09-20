using System.ComponentModel.DataAnnotations;

namespace StudentProject.Models
{
    public class UserModel
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [StringLength(16, ErrorMessage = "Must be between 3 and 16 characters", MinimumLength = 3)]

        public string Username { get; set; }
        public string gender { get; set; }
       // [StringLength(50, ErrorMessage = "Must be between 5 and 50 characters", MinimumLength = 5)]
        // [RegularExpression("^[a-zA-Z0-9_.]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(10, ErrorMessage = "Must be 10 digit", MinimumLength = 10)]
        public string PhoneNumber { get; set; }
      
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]

        public string hashPassword { get; set; }


    }
}
