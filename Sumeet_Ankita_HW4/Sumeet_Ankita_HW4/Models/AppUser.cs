using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

//TODO: Make this namespace match your project name
namespace Sumeet_Ankita_4.Models
{
    public class AppUser : IdentityUser
    {
        //TODO: Add custom user fields - first name is included as an example
        [Display(Name="First Name")]
        public String? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public String? LastName { get; set; }


    }
}
