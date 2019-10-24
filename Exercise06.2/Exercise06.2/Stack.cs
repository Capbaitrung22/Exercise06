using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06._2
{
    public class Stack
    {
            string[] Buffer;
            int Top;

            public Stack(int size)
            {
                Buffer = new string[size];
                Top = -1;
        
            }
        /// <summary>
        /// Initilize Stack with Buffer
        /// </summary>
        public Stack()
        {
            Buffer = new string[1000];
        }
        public void Push(string value)
        {
            Buffer[Top + 1] = value;
            Top = Top + 1;
        }
        public string Pop()
        {
            string value = Buffer[Top];
            Top = Top - 1;
            return value;
        }
        public string peek()
        {
            return Buffer[Top];
        }

        public int Count()
        {
            return Top + 1;
        }

        public void Clear()
        {
            Top = -1;
        }
    
    }
}
