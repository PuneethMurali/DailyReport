using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    enum Season { summer = 12, rainy = 15, winter }
    enum Months { jan, feb, march = 25 }
    enum weekdays { mon, tues, wed }
    internal class Class2
    {
        static void Main(string[] args)
        {
            Season s1 = Season.summer;
            Console.WriteLine(s1);
            Console.WriteLine(Season.winter);
            //type cast
            int n1 = (int)Season.winter;
            Console.WriteLine(n1);
            Customers c = new Customers();
            c.Display();
            // Primitive dat type int,bool, float are pre-defined as structs in .net
        }
        struct Customers
        {
            public int id; public string name;
            public void Display()
            {
                id = 100;
                name = "Amit";
                Console.WriteLine("{0}\t {1}", id, name);
            }

        }
    }
}
