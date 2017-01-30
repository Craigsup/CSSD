using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace TicketingSystem {
    [Serializable]
    [DataContract]
    public class Account {
        [DataMember]
        private int AccountID;
        [DataMember]
        private string FullName;
        [DataMember]
        private string Password;
        [DataMember]
        private bool LoginStatus;
        [DataMember]
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
            var x = username == Username && password == Password;
            var accs = ReadFromBinaryFile<List<Account>>(@"Accounts.txt");
            foreach (var account in accs) {
                if (account.Username == username && account.Password == password) {
                    return account.AccountID;
                }
            }

            return -1;
        }

        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
