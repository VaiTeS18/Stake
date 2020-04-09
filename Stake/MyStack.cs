using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stake
{
    class MyStack
    {
        private int[] data;
        public int count;
        public MyStack()
        {
            data = new int[0];
            

        }
        public void Push(int x)
        {
            Array.Resize(ref data, count + 1);
            data[count] = x;
            ++count;
        }
        public int Top()
        {
            if (count > 0)
            {
                return data[count - 1];

            }
            else
                return default(int);
        }

        public int Pop()
        {
            if (count > 0)
            {

                var t = Top();
                Array.Resize(ref data, count - 1);
                count--;
                return t;
            }
            else
                throw new System.InvalidOperationException("lol");
            
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public void Clear()
        {
            Array.Resize(ref data, 0);
            count=0;
        }
    }
        
   
}
