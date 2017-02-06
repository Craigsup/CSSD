using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TicketingSystem {
    public class AccountList {
        private List<CustomerAccount> _listOfAccounts;

        public AccountList() {
            _listOfAccounts = new List<CustomerAccount>();
        }

        public AccountList(List<CustomerAccount> accs) {
            _listOfAccounts = new List<CustomerAccount>(accs);
        }

        public void AddCustomerAccount(CustomerAccount x) {
            _listOfAccounts.Add(x);
        }

        public CustomerAccount GetAccountByCardId(int x) {
            return _listOfAccounts.Where(y => y.GetCardId() == x).FirstOrDefault();
        }

        public Account GetAccountByUsername(string x) {
            return null;
        }

        public void SaveData() {
            WriteToBinaryFile(@"Accounts.txt", _listOfAccounts, false);
        }

        public void LoadData() {
            _listOfAccounts = ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt");
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

	public void UpdateData(int accountId, float topup)
        {
            var accs = ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt");
            foreach (var account in accs)
            {
                if (accountId == account.GetAccountId())
                {
                    account.UpdateBalance(topup);
                    
                }
            }
            _listOfAccounts = accs;
            SaveData();
        }
    }
}