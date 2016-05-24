using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            mc.Write(mc.Add(3, 6));
        }

        static void WriteWord(string s)
        {
            Console.WriteLine(s);
        }
    }
}
