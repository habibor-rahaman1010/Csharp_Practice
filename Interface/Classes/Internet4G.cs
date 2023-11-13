using Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Classes
{
    public class Internet4G : IInternetService
    {
        public void Activate()
        {
            Console.WriteLine("Internet 4G Connecting...");
        }
        public void EstablishConnection(string host, string userName, string password)
        {
            Console.WriteLine($"Host: {host} User Nmae: {userName} Password: {password}");
            Activate();
        }
    }
}
