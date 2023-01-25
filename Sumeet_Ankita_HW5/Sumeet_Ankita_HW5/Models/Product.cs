using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sumeet_Ankita_HW5.Models
{
    public enum ProductType
    {
        [Display(Name = "New Hardback")] NewHardback,
        [Display(Name = "New Paperback")] NewPaperback,
        [Display(Name = "Used Hardback")] UsedHardback,
        [Display(Name = "Used Paperback")] UsedPaperback,
        Other
    }

    public class Product
    {
        public Int32 ProductID { get; set; }

        [Required(ErrorMessage = "Product name is required!")]
        [Display(Name = "Product Name:")]
        public String ProductName { get; set; }

        [Display(Name = "Product Description:")]
        public String Description { get; set; }

        [Required(ErrorMessage = "Product price is required!")]
        [Display(Name = "Product Price:")]
        [DisplayFormat(DataFormatString = "{0:c}")]

        public Decimal ProductPrice { get; set; }

        [Display(Name = "Product Type:")]
        public ProductType ProductType { get; set; }

        public List<Supplier> Suppliers { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }

}

