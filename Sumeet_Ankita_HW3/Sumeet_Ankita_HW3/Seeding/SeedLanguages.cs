using Sumeet_Ankita_HW3.DAL;
using Sumeet_Ankita_HW3.Models;
using Sumeet_Ankita_HW3.DAL;
using Sumeet_Ankita_HW3.Models;
using System.Text;

namespace Sumeet_Ankita_HW3.Seeding
{
    public static class SeedLanguages
    {
        public static void SeedAllLanguages(AppDbContext db)
        {
            //check to see if all the languages have already been added
            if (db.Languages.Count() == 16)
            {
                //exit the program - we don't need to do any of this
                NotSupportedException ex = new NotSupportedException("Language record count is already 21!");
                throw ex;
            }

            //create a counter to help debug
            int intLanguageID = 0;
            string strLanguageName = "Start";

            //create the new list of languages
            try
            {
                //Create a list of languages
                List<Language> AllLanguages = new List<Language>();

                //Add all the languages
                AllLanguages.Add(new Language { LanguageName = "C" });
                AllLanguages.Add(new Language { LanguageName = "C++" });
                AllLanguages.Add(new Language { LanguageName = "CSS" });
                AllLanguages.Add(new Language { LanguageName = "Dart" });
                AllLanguages.Add(new Language { LanguageName = "Go" });
                AllLanguages.Add(new Language { LanguageName = "HTML" });
                AllLanguages.Add(new Language { LanguageName = "Java" });
                AllLanguages.Add(new Language { LanguageName = "JavaScript" });
                AllLanguages.Add(new Language { LanguageName = "PHP" });
                AllLanguages.Add(new Language { LanguageName = "Python" });
                AllLanguages.Add(new Language { LanguageName = "Ruby" });
                AllLanguages.Add(new Language { LanguageName = "Rust" });
                AllLanguages.Add(new Language { LanguageName = "Shell" });
                AllLanguages.Add(new Language { LanguageName = "TypeScript" });
                AllLanguages.Add(new Language { LanguageName = "Vue" });
                AllLanguages.Add(new Language { LanguageName = "Other" });



                //loop through the list and see which (if any) need to be added
                foreach (Language lang in AllLanguages)
                {
                    //see if the language already exists in the database
                    Language dbLanguage = db.Languages.FirstOrDefault(x => x.LanguageName == lang.LanguageName);

                    //language was not found
                    if (dbLanguage == null)
                    {
                        //Add the language
                        db.Languages.Add(lang);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was an error adding the ");
                msg.Append(strLanguageName);
                msg.Append(" language (LanguageID = ");
                msg.Append(intLanguageID);
                msg.Append(")");
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}
