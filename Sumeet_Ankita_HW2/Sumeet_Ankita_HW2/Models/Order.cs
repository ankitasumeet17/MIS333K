using System;
using System.ComponentModel.DataAnnotations;
namespace Sumeet_Ankita_HW2.Models
{
    //create enum
    public enum CustomerType {[Display(Name = "Direct")] Direct, Wholesale}
    public abstract class Order
    {
        //constant variables
        public const Decimal HARDBACK_PRICE = 17.95m;
        public const Decimal PAPERBACK_PRICE = 9.50m;

        //customer type property
        [Display(Name = "Customer Type:")]
        public CustomerType CustomerType { get; set; }

        //number of hardbacks property
        [Display(Name = "Number of Hardback Books:")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        [Required(ErrorMessage = "Number of hardbacks is required!")]
        [Range(0,1000000, ErrorMessage = "The number of hardbacks must be at least zero!\r\n")]
        public Int32 NumberOfHardbacks { get; set; }

        //number of paperbacks property
        [Display(Name = "Number of Paperback Books:")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        [Required(ErrorMessage = "Number of paperbacks is required!")]
        [Range(0, 1000000, ErrorMessage = "The number of paperbacks must be at least zero!\r\n")]
        public Int32 NumberOfPaperbacks { get; set; }

        //hardback subtotal property
        [Display(Name = "Hardback Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal HardbackSubtotal { get; set; }

        //paperback subtotal property
        [Display(Name = "Paperback Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal PaperbackSubtotal { get; set; }

        //subtotal property
        [Display(Name = "Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Subtotal { get; set; }

        //total property 
        [Display(Name = "Total:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Total { get; set; }

        //total items property
        [Display(Name = "Total Number of Books:")]
        public Int32 TotalItems { get; set; }

        //calc subtotal method
        public void CalcSubtotals()
        {
            TotalItems = NumberOfHardbacks + NumberOfPaperbacks;

            if (TotalItems == 0)
            {
                throw new Exception("Total Items cannot be 0!");
            }
            HardbackSubtotal = NumberOfHardbacks * HARDBACK_PRICE;
            PaperbackSubtotal = NumberOfPaperbacks * PAPERBACK_PRICE;
            Subtotal = HardbackSubtotal + PaperbackSubtotal;
        }
    }
}


