using System.Collections.Generic;
using System.IO;

namespace TicketingSystem
{
    public class AccountList {
        private List<Account> _listOfAccounts;

        public AccountList() {
            _listOfAccounts = new List<Account>();
        }

        public void AddCustomerAccount(CustomerAccount x) {
            _listOfAccounts.Add(x);
        }

        public Account GetAccountByCardId(int x) {
            return null;
        }

        public Account GetAccountByUsername(string x) {
            return null;
        }

    }
}