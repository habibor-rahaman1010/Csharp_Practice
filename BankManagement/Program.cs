using System;
using BankManagement.Users;
using BankManagement.Hello;
using static BankManagement.Hello.ContainerClass;

namespace BankManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list_branch = new List<string>() { "Mohammodpur", "Dhanmondi", "Motijhil", "Gulshan"};
                
            Bank Asia = new Bank("Asia Bank", list_branch);
            Console.Write("Asia Bank all branch: ");
            foreach (string item in Asia.branch)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");



            Account habib =  Asia.CreateAccount("Habibor Rahaman", 12500, "habibor@gmail.com", "Dhaka", "Personal", "habibor144369", true);
            habib.AccountInformation();
            habib.Withdraw(2000);
            Console.WriteLine();

            Account rifat = Asia.CreateAccount("Rifat Ahmed", 45800, "rifat.ahmed@gmail.com", "Dhaka", "Agent", "rifat7237", true);
            rifat.AccountInformation();
            rifat.Withdraw(2000);

            Console.WriteLine($"Bank Blance: {Asia.bankBlance()}");



            //access mofidire in class...
            ContainerClass containerClass = new ContainerClass();
            helloClass n = new helloClass();
            containerClass.MonkeySound();
        }
    } 
}