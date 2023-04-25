using MVCHOT2.Models.DomainModels;
using Microsoft.AspNetCore.Identity;

namespace MVCHOT2.Models.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; } = null!;

        public IEnumerable<IdentityRole> Roles { get; set; } = null!;
    }
}
