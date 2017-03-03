using System.Collections.Generic;
using System.Linq;

namespace ModifiedTicketingSystem {
    public class LanguageList {
        private List<Language> ListOfLanguages;

        public LanguageList() {
            ListOfLanguages = new List<Language>();
        }

        public Language GetLanguageByName(string name) {
            return ListOfLanguages.Where(x => x.GetNameOfLang() == name).First();
        }

        public List<Language> GetAllLanguages() {
            return ListOfLanguages;
        }

        public void AddLanguage(Language lang) {
            ListOfLanguages.Add(lang);
        }
    }
}
