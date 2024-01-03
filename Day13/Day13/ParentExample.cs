using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public class ParentExample
    {
        public void Building()
        {
            Console.WriteLine("all classes of same project or another will able to access public member ");
        }
        protected void LicPolicy()
        {
            Console.WriteLine("all classes of same project  will able to access protected member ");
        }// secured
        private void Education()
        {
            Console.WriteLine("never accessible outside the class ");
        }
    }
    public class Child1 : ParentExample
    {
        static void Main(string[] args)
        {
            Child1 c1 = new Child1();
            c1.Building();// child object is able enjoy building and licpolicy 
            c1.LicPolicy();//child instance is able to access public,protected but not private
                           // check with parent instance
            ParentExample pe = new ParentExample();
            pe.Building();// only public not event protected ,private 

        }
    }
    class Testing
    {
        static void Main(string[] args)
        {
            // child , parent instance , please check again
        }
    }
}
