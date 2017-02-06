using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace TicketingSystem {
    [Serializable]
    [DataContract]
    public class Account {
        [DataMember]
        protected int _accountId;
        [DataMember]
        protected string _fullName;
        [DataMember]
        protected string _password;
        [DataMember]
        protected bool _loginStatus;
        [DataMember]
        protected string _username;

        public Account(int accountId, string username, string password, string fullName, bool loginStatus) {
            _accountId = accountId;
            _fullName = fullName;
            _password = password;
            _loginStatus = loginStatus;
            _username = username;
        }

        public Account() {

        }

        public Account GetAccount() {
            return this;
        }

        public string GetName() {
            return _fullName;
        }

        public string GetUsername() {
            return _username;
        }

        public int GetAccountId() {
            return _accountId;
        }

        public int VerifyLogin(string username, string password) {
            var x = username == _username && password == _password;
            var accs = ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt");
            foreach (var account in accs) {
                if (account._username == username && account._password == password) {
                    return account._accountId;
                }
            }

            return -1;
        }

        public Account VerifyLoginAndReturnAccount(int userId)
        {
            var accs = ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt");
            foreach (var account in accs)
            {
                if (userId == account._accountId)
                {
                    return account;
                }
            }
            return null;
        }

        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
