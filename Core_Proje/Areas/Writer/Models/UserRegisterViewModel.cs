using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter a username.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a surname.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter a Image URL.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Please enter your password again.")]
        [Compare("Password", ErrorMessage = "The passwords entered are not the same.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter a email address.")]
        public string Mail { get; set; }
    }
}
