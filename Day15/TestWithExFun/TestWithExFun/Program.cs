using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceBank;
namespace TestWithExFun {
    static class BankExt    {
     public    static void ExtTapCard(this Bank b)        {
            Console.WriteLine("this is extention method");        }    }
    internal class Program {       
        static void Main(string[] args)        {
            Bank b = new Bank();
            //existing part old app
            b.Current();
            b.Savings();
            b.Recurring();
            // extention of bank with new feature
            b.ExtTapCard();
            //System.Collections.IEnumerable;
            //System.Collections.IEnumerator;
            //System.Collections.Generic.IEnumerator
            System.Collections.Generic.List<int> l1;
            //System.Collections.Generic.IEnumerable<int> l2;

        }
    }
}
