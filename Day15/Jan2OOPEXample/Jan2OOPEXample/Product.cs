using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan2OOPEXample
{
    static  class Product   {
        static void Display() { }
    }
  partial class Products {// dev 1 in his system
    public void Display() { }
        public static void dis() { }
       // partial void D1() { }
    }
    partial class Products { }// another dev 
    partial class Products { // team lead who is testing and merging 
        static void Main(string[] args)
        {
            Products ps = new Products();
            ps.Display();
        }
    }
  //  public class Test {  partial void T1() { } }
}
