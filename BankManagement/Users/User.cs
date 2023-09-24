using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Users
{
    internal abstract class User
    {
        public string user_name { get; set; } = string.Empty;
        protected int _balance { get; set; }
        public string email { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
    }
}
