using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCHOT2.Models.DomainModels
{
    public class User : IdentityUser
    {
        [NotMapped] // This attribute makes it so that this property will not be mapped in the database column
        public IList<string> RoleNames { get; set; } = null!;
    }
}
