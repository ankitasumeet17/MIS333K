using System;
using System.ComponentModel.DataAnnotations;
namespace Sumeet_Ankita_HW2.Models
{
    public class WholesaleOrder : Order
    {
        //customer code property 
        [Display(Name = "Customer Code:")]
        [StringLength(6, ErrorMessage = "Customer code must be 4-6 characters", MinimumLength = 4)]
        [RegularExpression(@"^^[a-zA-Z]+$", ErrorMessage = "Customer code may only contain letters")]
        [Required(ErrorMessage = "Customer Code is required!")]
        public String CustomerCode { get; set; }

        //delivery fee property 
        [Display(Name = "Delivery Fee:")]
        [Required(ErrorMessage = "Delivery Fee is required!")]
        [Range(0, 250, ErrorMessage = "Delivery Fee must be between 0 and 250!\r\n")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal DeliveryFee { get; set; }

        //preferred customer property 
        [Display(Name = "Is this customer a preferred customer?")]
        public Boolean PreferredCustomer { get; set; }

        //calculate total method
        public void CalcTotals()
        {
            base.CalcSubtotals();

            if (PreferredCustomer == true || Subtotal >= 1200)
            {
                DeliveryFee = 0;
            }
            Total = Subtotal + DeliveryFee;
        }
    }
}