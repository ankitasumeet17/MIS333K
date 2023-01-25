using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;
namespace Sumeet_Ankita_HW5.Models
{
    public class AppUser : IdentityUser
    {

        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "User Name")]
        public String FullName 
        {
            get { return FirstName + " " + LastName; }
        }

        public List<Order> Orders { get; set; }

        public AppUser()
        {
            if (Orders == null)
            {
                Orders = new List<Order>();
            }
        }
    }
}

