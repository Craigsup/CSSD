namespace TicketingSystem {
    public class Account {
        private int _accountId;
        private string _fullName;
        private string _password;
        private bool _loginStatus;
        private string _username;

        public Account(int accountId, string fullName, string password, bool loginStatus, string username) {
            _accountId = accountId;
            _fullName = fullName;
            _password = password;
            _loginStatus = loginStatus;
            _username = username;
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
