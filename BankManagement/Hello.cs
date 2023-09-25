using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Hello
{
    public class ContainerClass
    {
        private protected class PrivateClass
        {
            // This class is only accessible within ContainerClass.
        }

        protected internal class ProtectedClass
        {
            // This class is accessible within ContainerClass and its derived classes.
        }

        internal class helloClass
        {
            
        }

        private protected void DogSound()
        {
            Console.WriteLine("Ghew Ghew");
        }
        protected internal void CatSound()
        {
            Console.WriteLine("Mew Mew");
        }
        public void MonkeySound()
        {
            Console.WriteLine("monkey monkey");
        }
    }
}
