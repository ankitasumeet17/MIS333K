using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sumeet_Ankita_HW0.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public String Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public String Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public Boolean? WillAttend { get; set; }
    }
}
