using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Users
{
    internal class Account : User
    {
        public string accountName {  get; set; } = string.Empty;
        public string accountType { get; set; } = string.Empty;
        public bool isActive { get; set; }

        public Account(string user_name, int blance, string email, string address, string accountType, string accountName, bool isActive) { 
            this.user_name = user_name;
            this.Blance = blance;
            this.email = email;
            this.address = address;
            this.accountType = accountType;
            this.accountName = accountName;
            this.isActive = isActive;
        }

        public int Blance {
            get
            {
                return _balance;
            }
            set
            {
                if(value < 0)
                {
                    _balance = 0;
                }
                else
                {
                    _balance = value;
                }
            }
        }

        public void Deposit(int amount)
        {
            if(amount < 0)
            { 
                _balance += 0;
            }
            else
            {
                _balance += amount;
            }
            Console.WriteLine($"Deposit add: {amount}Tk");
            Console.WriteLine($"Current balnce is: {_balance}Tk");
        }

        public void Withdraw(int amount)
        {
            if(amount < 0)
            {
                _balance -= 0;
            }
            else
            {
                _balance -= amount;
            }
            Console.WriteLine($"Withdraw blance: {amount}Tk");
            Console.WriteLine($"Current balnce is: {_balance}Tk");
        }
        public void AccountInformation()
        {   
            Console.WriteLine($"Name: {this.user_name}");
            Console.WriteLine($"Balance: {this.Blance}");
            Console.WriteLine($"Email: {this.email}");
            Console.WriteLine($"Address: {this.address}");
            Console.WriteLine($"Account Type: {this.accountType}");
            Console.WriteLine($"Account Name: {this.accountName}");
            Console.WriteLine($"isActive: {this.isActive}");
            Console.WriteLine();
        }
    }
}
