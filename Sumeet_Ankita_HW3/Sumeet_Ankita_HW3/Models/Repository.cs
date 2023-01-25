using System.ComponentModel.DataAnnotations;

namespace Sumeet_Ankita_HW3.Models
{
    public enum Category { Code, Education, Resources, Other }
    public class Repository
    {
        [Display(Name = "Repo ID")]
        public Int32 RepositoryID { get; set; }

        [Display(Name = "User Name")]
        public String UserName { get; set; }

        [Display(Name = "Repo Name")]
        public String RepositoryName { get; set; }

        public String Description { get; set; }

        [DataType(DataType.Url)]
        public String URL { get; set; }

        [Display(Name = "Last Update")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime LastUpdate { get; set; }

        [Display(Name = "Star Count (In Thousands)")]
        [DisplayFormat(DataFormatString = "{0:n}")]
        public Decimal StarCount { get; set; }

        public Category Category { get; set; }

        //navigational property for language
        public Language Language { get; set; }
    }
}
