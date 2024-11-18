using System.ComponentModel.DataAnnotations;

namespace FluentLab.ViewsModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }
        public string test2 { get; set; }
    }
}
