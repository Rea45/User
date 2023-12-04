using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace User.Models.SignUp;

public class RegisterUser
{

    public class ApplicationUser : IdentityUser
    {
        [Required]

        public string Login { get; set; }

        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }

        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [RegularExpression(@"(?=.*\W)?(?=.*\d)", ErrorMessage = "Error message")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
    }
    

}




