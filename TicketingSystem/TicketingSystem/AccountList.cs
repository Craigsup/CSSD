﻿using System.Collections.Generic;
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
        public CustomerAccount GetAccountByUsername(string x) {
            return _listOfAccounts.Where(y => y.GetUsername() == x).First();
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
        /// This method takes the List of CustomerAccount object and binary serializes it, allowing the persistence of data.
        /// </summary>
        /// <param name="filePath">This is the file name/output directory.</param>
        /// <param name="objectToWrite">This is the object that gets serialized. Can be of any type.</param>
        /// <param name="append">This flags whether to append the object to the end of the file (if it exists already)</param>
        /// <typeparam name="T">This is the type of T</typeparam>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false) {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        /// This method reads in the object that has been serialized and returns it to the calling statement.
        /// </summary>
        /// <param name="filePath">A string containing the file path of which file to load.</param>
        /// <typeparam name="T">The return type which the object should be cast to, in order to be returned.</typeparam>
        /// <returns></returns>
        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

	/// <summary>
	/// This method gets the valid user account and calls the update balance method to add the amount they wish to top up to their account balance.
	/// </summary>
	/// <param name="accountId">The account ID of which account to top up.</param>
	/// <param name="topup">How much the user wishes to top up.</param>
	public void UpdateData(int accountId, decimal topup)
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