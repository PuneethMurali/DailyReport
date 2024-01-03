using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan2OOPEXample
{
    public class Sample   {  public  Sample() { }
        public Sample(Sample s) { }
        private Sample(int x) { }
    }
    internal class Program: Sample
    {
        static void Main(string[] args)
        {
           // Sample s1 = new Sample();//clr generates , that is default constructor
         //   Sample s2 = new Sample(s1);
           // Sample s3 = new Sample(10);

//.net 4.0 introduced object initializer 
List<Customer> cs = new List<Customer>() {
            new Customer{ Id= 10},new Customer(){ Id= 20 } };
            Customers c1 = new Customers();
            c1.display();
        

        }
        public class Customer {
            public int Id { get; 
                set; } 
            //auto implicit property declaration .net 3.5
            public int Name { get; set; }
        }
        private class Customers {
        public void display() { }
        }
    }
   // private class Customers {

  //  }
    public abstract class animal { 
        int legs = 4;int tail = 1;//these are common to all category of animal
        public abstract void eats(); }
    ////public class Dog: animal
    ////{

    ////////}
}
