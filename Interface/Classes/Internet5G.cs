using Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Classes
{
    public class Internet5G : IInternetService
    {
        public void Connected()
        {
            Console.WriteLine("Internet 5G Connecting...");
        }
        public void EstablishConnection(string host, string userName, string password)
        {
            Console.WriteLine($"Host: {host} User Nmae: {userName} Password: {password}");
            Connected();
        }
    }
}
