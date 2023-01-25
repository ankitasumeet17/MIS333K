using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Sumeet_Ankita_HW5.Models;

namespace Sumeet_Ankita_HW5.Models
{
    //add order status here if needed
    public enum OrderStatus { Pending, Completed }

    public class Order
    {
        public const Decimal TAX_RATE = 0.0825m;

        public Int32 OrderID { get; set; }

        //NOTE: edit range if needed
        [Display(Name = "Order Number:")]
        public Int32 OrderNumber { get; set; }

        [Display(Name = "Order Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Order Notes:")]
        public String OrderNotes { get; set; }

        [Display(Name = "Order Status:")]
        public OrderStatus Status { get; set; }

        //NOTE: edit name TotalFees based on OrderDetail file
        [Display(Name = "Order Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal
        {
            //NOTE: check if variables are right
            get { return OrderDetails.Sum(od => od.ExtendedPrice); }
        }

        [Display(Name = "Tax Rate")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TaxRate
        {
            get { return OrderSubtotal * TAX_RATE; }
        }

        [Display(Name = "Order Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + TaxRate; }
        }

        //navigational properties

        public List<OrderDetail> OrderDetails { get; set; }

        public AppUser User { get; set; }

        //NOTE: Edit if relations are wrong
        public Order()
        {
            if (OrderDetails == null)
            {
                OrderDetails = new List<OrderDetail>();
            }
        }
    }
}
