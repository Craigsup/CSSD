using System.Collections.Generic;
using System.IO;

namespace TicketingSystem {
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

        public void SaveData() {
            WriteToBinaryFile(@"Accounts.txt", _listOfAccounts, false);
        }

        public void LoadData() {
            _listOfAccounts = ReadFromBinaryFile<List<Account>>(@"Accounts.txt");
        }


        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false) {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }


        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}