using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TicketingSystem {
    /// <summary>
    /// 
    /// </summary>
    public class AccountList {
        private List<CustomerAccount> _listOfAccounts;

        /// <summary>
        /// 
        /// </summary>
        public AccountList() {
            _listOfAccounts = new List<CustomerAccount>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accs"></param>
        public AccountList(List<CustomerAccount> accs) {
            _listOfAccounts = new List<CustomerAccount>(accs);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        public void AddCustomerAccount(CustomerAccount x) {
            _listOfAccounts.Add(x);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public CustomerAccount GetAccountByCardId(int x) {
            return _listOfAccounts.Where(y => y.GetCardId() == x).FirstOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Account GetAccountByUsername(string x) {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        public void SaveData() {
            WriteToBinaryFile(@"Accounts.txt", _listOfAccounts, false);
        }

        /// <summary>
        /// 
        /// </summary>
        public void LoadData() {
            _listOfAccounts = ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="objectToWrite"></param>
        /// <param name="append"></param>
        /// <typeparam name="T"></typeparam>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false) {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

	/// <summary>
	/// 
	/// </summary>
	/// <param name="accountId"></param>
	/// <param name="topup"></param>
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