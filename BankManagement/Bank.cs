using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagement.Users;

namespace BankManagement
{
    internal class Bank
    {
        public string bank_name { get; set; } = string.Empty;
        public int total_accounts { get { return allUsers.Count;} private set { } }
        public List<Account> allUsers = new List<Account>();
        public List<Account> lsit_account { get; set;} = new List<Account>();
        public List<string> branch { get; set; } = new List<string>();


        public Bank(string bank_name, List<string> branch)
        {
            this.bank_name = bank_name;
            this.branch = branch;
        }
        public int bankBlance()
        {
            int all_user_blancee = 0;
            foreach (var account in allUsers)
            {
                all_user_blancee += account.Blance;
            }
            return all_user_blancee;
        }

        public Account CreateAccount(string user_name, int blance, string email, string address, string account_type, string accountName, bool isActive)
        {
            Account user =  new Account( user_name, blance, email, address, account_type, accountName, isActive);
            allUsers.Add(user);
            return user;
        }
    }
}
