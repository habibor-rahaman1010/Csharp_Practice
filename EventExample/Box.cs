using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    public class Box
    {
        public event Action<DateTime> Opened;
        public event Action<DateTime> Closed;
        public event EventHandler Message;
        public event Func<int, int, int> Sum;

        public void Open()
        {
            Opened?.Invoke(DateTime.Now);
        }

        public void Close() 
        {
            Closed?.Invoke(DateTime.Now); 
        }

        public int Summation(int x, int y)
        {
            return Sum?.Invoke(x, y) ?? 0;
        }

        public void SMS()
        {
            Message?.Invoke(this, EventArgs.Empty);
        }
    }
}
