using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem {
    public class Account {
        private int AccountID;
        private string FullName;
        private string password;
        private bool LoginStatus;
        private string Username;

        public Account(int accountId, string fullName, string password, bool loginStatus, string username) {
            AccountID = accountId;
            FullName = fullName;
            this.password = password;
            LoginStatus = loginStatus;
            Username = username;
        }

        public int GetAccount() {
            return 0;
        }

        public string GetName() {
            return "";
        }

        public string GetUsername() {
            return "";
        }

        public bool VerifyLogin(string x, string y) {
            return false;
        }
    }
}
