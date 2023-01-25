using System;
using System.ComponentModel.DataAnnotations;

namespace Sumeet_Ankita_HW5.Models
{
    public class Supplier
    {
        public Int32 SupplierID { get; set; }

        [Display(Name = "Supplier Name")]
        public String SupplierName { get; set; }

        [Display(Name = "Supplier Email")]
        public String Email { get; set; }

        [Display(Name = "Phone Number")]
        public String PhoneNumber { get; set; }

        public List<Product> Products { get; set; }

    }
}

