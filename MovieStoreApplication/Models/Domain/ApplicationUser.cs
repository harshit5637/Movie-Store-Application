using Microsoft.AspNetCore.Identity;

namespace MovieStoreApplication.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
