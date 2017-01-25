using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem {
    public class Account {
        private int AccountID;
        private string FullName;
        private string Password;
        private bool LoginStatus;
        private string Username;

        public Account(int accountId, string username, string password, string fullName, bool loginStatus) {
            AccountID = accountId;
            FullName = fullName;
            Password = password;
            LoginStatus = loginStatus;
            Username = username;
        }

        public Account() {
            
        }

        public Account GetAccount() {
            return this;
        }

        public string GetName() {
            return FullName;
        }

        public string GetUsername() {
            return Username;
        }

        public int VerifyLogin(string username, string password) {
            return 0;
        }
    }
}
