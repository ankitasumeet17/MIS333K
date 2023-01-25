using System.ComponentModel.DataAnnotations;

//TODO: Update this namespace to match your project's name
namespace Sumeet_Ankita_HW3.Models
{
    public class Language
    {
        public Int32 LanguageID { get; set; }

        [Display(Name = "Name")]
        public String LanguageName { get; set; }

        public List<Repository> Repositories { get; set; }
    }
}
