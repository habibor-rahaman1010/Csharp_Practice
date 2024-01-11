using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    public class KeyBoard
    {
        private List<char> Keys = new List<char>();
        private char[,] TowDimentionKey;

        public char this[int position]
        {
            get { return Keys[position]; }
            set { Keys[position] = value; }
        }

        public char this[int row, int col]
        {
            get { return TowDimentionKey[row, col]; }
            set { TowDimentionKey[row, col] = value; }
        }
       

        public KeyBoard() 
        {
            Keys.Add('A');
            Keys.Add('B');
            Keys.Add('H');
            Keys.Add('N');

            TowDimentionKey = new char[,]
            {
                {'A', 'B', 'C', 'D'},
                {'E', 'F', 'G', 'H'},
                {'I', 'J', 'K', 'L'},
                {'M', 'N', 'O', 'P'}
            };

        }
    }
}
