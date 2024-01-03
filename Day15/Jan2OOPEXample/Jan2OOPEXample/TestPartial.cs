using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan2OOPEXample
{
    internal class TestPartial {
        static void Main(string[] args)        {
            ClassA cls = new ClassA();
            cls.SetSalary();// will call SetData() , which is partial method
            // cls.SetData(); compiler error becuase another class will not access partial method
        }    }
    public partial class ClassA  {        partial void SetData();    }
    public partial class ClassA    { public void SetSalary() {   SetData();  // Perform other functionality here
        }
        partial void SetData()      {     Console.Write("This is a partial method.");
            Console.ReadKey();
        }
    }

}
}
