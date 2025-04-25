using Microsoft.AspNetCore.Identity;
namespace TiemposDeComida.Domain.Entities

{
    public class ApplicationUser : IdentityUser
    {
        public ProfileUser ProfileUser { get; set; } = null!;
    }
}
