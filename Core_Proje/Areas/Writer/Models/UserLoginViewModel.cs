using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Username")]
        [Required(ErrorMessage = "Please enter a username!")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter a password!")]
        public string Password { get; set; }
    }
}
