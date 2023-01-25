using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Sumeet_Ankita_HW3.Models;

namespace Sumeet_Ankita_HW3.Models
{
    public enum SearchType { [Display(Name = "Greater Than")] GreaterThan, [Display(Name = "Less Than")] LessThan }

    public class SearchViewModel
    {
        // Title
        [Display(Name = "Search by Title: ")]
        public String Title { get; set; }

        // Description
        [Display(Name = "Search by Description: ")]
        public String Description { get; set; }

        // Category
        [Display(Name = "Search by Category: ")]
        public Category? Category { get; set; }

        // Language
        [Display(Name = "Search by Language: ")]
        public Int32? SearchLanguage { get; set; }

        // Star Count
        [Display(Name = "Search by Star Count: ")]
        [Range(0, 1000000, ErrorMessage = "Quantity must be greater than or equal to zero!")]
        public Decimal? StarCount { get; set; }


        // Search Type
        [Display(Name = "Search Type: ")]
        public SearchType? SearchType { get; set; }


        // Updated After
        [Display(Name = "Search by Date Updated After: ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime? UpdatedAfter { get; set; }
    }
}

