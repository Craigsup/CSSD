using System.Collections.Generic;
using System.Linq;

namespace TicketingSystem {
    public class LanguageList {
        private readonly List<Language> _listOfLanguages;

        public LanguageList() {
            _listOfLanguages = new List<Language>();
        }

        public Language GetLanguageByName(string name) {
            return _listOfLanguages.Where(x => x.GetNameOfLang() == name).First();
        }

        public void AddLanguage(Language lang) {
            _listOfLanguages.Add(lang);
        }
    }
}
