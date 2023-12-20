using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class MyOwnError : ApplicationException// : means inheritence
    {// MyOwnError is child class of ApplicationException is parent(base) super class
        public void MyownEr()
        {
            Console.WriteLine(" An Exception Happened");
        }
        public void MyOwnDivideByError()
        {
            Console.WriteLine("Exception happened , division should not be zero");
        }
    }//end of class
    public class OwnException
    {
        static void Main(string[] args)
        {
            int n, div, Ans;
            Console.WriteLine("enter a number  0 ");
            div = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a real number");
            n = int.Parse(Console.ReadLine());
            try
            {
                if (div == 0)
                {
                    throw new MyOwnError();//class name we created like
                    //throw new DivideByZero()
                }
            }
            catch (MyOwnError e) { e.MyOwnDivideByError(); }
            Ans = n / div;
            Console.WriteLine("the ans is " + Ans);
        }
    }
}


