using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

//TODO: Change this namespace to match your project
namespace Sumeet_Ankita_4.Models
{
    public class RoleEditModel
    {
        public IdentityRole? Role { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public IEnumerable<AppUser> RoleMembers { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public IEnumerable<AppUser>? RoleNonMembers { get; set; }
    }

    public class RoleModificationModel
    {
        [Required]
        public string? RoleName { get; set; }
        public string[]? IdsToAdd { get; set; }
        public string[]? IdsToDelete { get; set; }
    }
}