using Microsoft.AspNetCore.Identity;

namespace FutureFridgesCW.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }

        public string Gender { get; set;}
    }
}
