using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class StaticVSNonStatic
    {
        public int x;
        static int y;
        static void Fun1()
        {
            y = 10;
            // x = 10000;
            Console.WriteLine(y);
        }//access only other static members y
        public void Fun2()
        {
            this.x = 20;
            y = 30;
            Console.WriteLine(" non static method is able to access static {0} and non static {1}  ", y, x);
        } // access both static , non static
        static void Main(string[] args)
        {
            StaticVSNonStatic.Fun1();
            StaticVSNonStatic ss = new StaticVSNonStatic();
            ss.Fun2();
        }
    }
}
