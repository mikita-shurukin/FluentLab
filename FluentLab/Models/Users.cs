using Microsoft.AspNetCore.Identity;

namespace FluentLab.Models
{
    public class Users: IdentityUser
    {
        public string FullName { get; set; }
    }
}
