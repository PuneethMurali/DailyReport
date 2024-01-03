using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;// next step do not forget
namespace ConsoleApp1 {
    static class CollegeExtending { public static void PostGrad(this College c) { Console.WriteLine(" post graduation is available for new students"); } }
    internal class Program    {
        static void Main(string[] args)
        {
            College c = new College();
            c.Tenth();c.Plus2();c.Graduation();c.PostGrad();

        }
    }
}
