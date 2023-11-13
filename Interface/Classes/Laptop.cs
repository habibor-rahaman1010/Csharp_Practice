using Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Classes
{
    public class Laptop
    {
        private IInternetService _internetService;
        public Laptop(IInternetService internetService) { 
            _internetService = internetService;
        }

        public void BrowseWebsite()
        {
            _internetService.EstablishConnection("3shost", "habibor144369", "c++c++c#");
        }
    }
}
