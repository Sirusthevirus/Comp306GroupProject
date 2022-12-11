using System.ComponentModel.DataAnnotations;

namespace Comp306GroupProject.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
<<<<<<< HEAD
=======
}
>>>>>>> 2df8ae2273c454fa7fe3355cc122d1ee5096595f
