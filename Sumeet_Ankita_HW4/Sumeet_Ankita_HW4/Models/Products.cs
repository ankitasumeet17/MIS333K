//add the namespace for data annotations
using System.ComponentModel.DataAnnotations;


namespace Sumeet_Ankita_4.Models
{
    public enum ProductType { New_Hardback, New_Paperback, Used_Hardback, Used_Paperback }
        
    public class Product
    {
        [Required]
        [Display(Name = "Product ID:")]
        public Int32 ProductID { get; set; }

        [Required]
        [Display(Name = "Product Name:")]
        public string? ProductName { get; set; }

        [Display(Name = "Product Description:")]
        public string? ProductDescription { get; set; }

        [Required]
        [Display(Name = "Product Price:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal ProductPrice { get; set; }

        [Required]
        [Display(Name = "Product Type:")]
        public ProductType ProductType { get; set; }

    }
}