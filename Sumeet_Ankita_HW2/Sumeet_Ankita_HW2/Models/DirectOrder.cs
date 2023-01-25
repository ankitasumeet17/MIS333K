using System;
using System.ComponentModel.DataAnnotations;
namespace Sumeet_Ankita_HW2.Models
{
    public class DirectOrder : Order
    {
        //constant variable
        const Decimal SALES_TAX_RATE = 0.0825m;

        //customer name property 
        [Display(Name = "Customer Name:")]
        [Required(ErrorMessage = "Customer name is required!")]
        public String CustomerName { get; set; }

        //sales tax property
        [Display(Name = "Sales Tax:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal SalesTax { get; set; }

        //calculate total method
        public void CalcTotals()
        {
            base.CalcSubtotals();
            SalesTax = Subtotal * SALES_TAX_RATE;
            Total = Subtotal + SalesTax;
        }
    }
}