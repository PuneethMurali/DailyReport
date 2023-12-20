using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class ClassWithLoops
    {
        static void ForLoopFun1()
        {
            for (int i = 0; i < 10; i++)// initialize;check value;increment
            {
                Console.WriteLine(" value of I " + i);//0-9
            }
        }
        static void ForEachLoopFun2()
        {
            int[] num = { 9, 33, 8, 2, 77 };
            // want to display num index values
            int i = 0;
            foreach (int n in num)
            {

                Console.WriteLine("value {0}  index is {1} ", n, i);
                i = i + 1;
            }
            for (int j = 0; j < num.Length; j++) { }
        }
        static void WhileLoop()
        {
            int i = 0;//initialize 
            while (i < 10) // checking 
            {
                Console.WriteLine("value of i is " + i);
                i++;//increment 
            }
        }
        static void DoWHileLoopFun4()
        {// execute, increment check
            int n = 10;
            do
            {
                Console.WriteLine(" value  is  " + n);
                n++;
            } while (n < 10);

        }

        static int MenuBased()
        {
            Console.WriteLine(" please select a chioce");
            Console.WriteLine("1 : For Loop");
            Console.WriteLine("2 : For each Loop");
            Console.WriteLine("3 : while Loop");
            Console.WriteLine("4 : do while Loop");
            Console.WriteLine(" 5 to exit ");
            int ch = int.Parse(Console.ReadLine());
            return ch;
        }
        static void Main(string[] args)
        {
            int c = MenuBased();

            switch (c)
            {
                case 1:
                    {
                        ForLoopFun1(); break;
                    }
                case 2:
                    {
                        ForEachLoopFun2(); break;
                    }
                case 3:
                    {
                        WhileLoop(); break;
                    }
                case 4:
                    {
                        DoWHileLoopFun4(); break;
                    }
                case 5:
                    {
                        System.Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Chooice");
                        break;
                    }

            }
            // DoWHileLoopFun4();
            //ForLoopFun1(); 
            // ForEachLoopFun2();
            //WhileLoop();
            Console.ReadLine();
        }
    }
}