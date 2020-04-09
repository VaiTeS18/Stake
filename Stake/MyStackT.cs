using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stake
{
    class MyStackT<T>
    {
        private T[] data;
        public int count;
        public MyStackT()
        {
            data = new T[0];


        }
        public void Push(T x)
        {
            Array.Resize(ref data, count + 1);
            data[count] = x;
            ++count;
        }
        public T Top()
        {
            if (count > 0)
            {
                return data[count - 1];

            }
            else
                return default(T);
        }

        public T Pop()
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
            count = 0;
        }
    }
}
