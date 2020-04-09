using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stake
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyStackT<string>();
            obj.Push("dfhsjk");
            obj.Push("sdfd");
            //obj.Clear();
            Console.WriteLine(obj.Top());
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Top());
            //Console.WriteLine(obj.Clear());

            Console.ReadKey();

        }
    }
}
