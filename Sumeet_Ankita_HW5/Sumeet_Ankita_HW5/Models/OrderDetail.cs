using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sumeet_Ankita_HW5.Models
{
    public class OrderDetail : Order
    {
        public Int32 OrderDetailID { get; set; }

        //[StringLength(100, ErrorMessage = "Quantity must be between 1 and 1000", MinimumLength = 6)]
        [Display(Name = "Quantity")]
        public Int32 Quantity { get; set; }

        [Display(Name = "Product Price")]
        public Decimal ProductPrice { get; set; }

        [Display(Name = "Extended Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ExtendedPrice { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}

