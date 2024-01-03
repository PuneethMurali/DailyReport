using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan2OOPEXample
{
    sealed class TestSealed
    {
        private int num1 = 100; 
        public int Ans {  get; set; }
        public void GetData() { }
    }
    public class ClientSealed{
        static void Main(string[] args)
        {
            TestSealed ts = new TestSealed();
            ts.GetData();
           
        }
    }
}
