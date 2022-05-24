using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutDemo
{
    internal class Program
    {
        public void OutRefExample(ref int a, out int b)
        {
            a = 100;

            b = 200;
        }

        static void Main(string[] args)
        {
            int x = 1;
            int y;

            Program obj = new Program();
            obj.OutRefExample(ref x, out y);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
