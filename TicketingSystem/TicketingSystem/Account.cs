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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="loginStatus"></param>
        public Account(int accountId, string username, string password, string fullName, bool loginStatus) {
            _accountId = accountId;
            _fullName = fullName;
            _password = password;
            _loginStatus = loginStatus;
            _username = username;
        }

        /// <summary>
        /// 
        /// </summary>
        public Account() {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Account GetAccount() {
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetName() {
            return _fullName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetUsername() {
            return _username;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetAccountId() {
            return _accountId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
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
    }
}
