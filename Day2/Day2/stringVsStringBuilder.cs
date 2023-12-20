using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class stringVsStringBuilder
    { 
    static void AllStringFuns()
    {
        string s1 = "Hello Today is Friday";
        // want to display Today
        string s2 = s1.Substring(6, 5);// start index,how much
                                       // Console.WriteLine(  s2);
                                       // how to break given string, when a space is there
        string[] strs = s1.Split(' ');//array best if foreach
        foreach (string s in strs)
        {
            // Console.WriteLine(s);
        }
        // lests is starting letter is H beacuse case-sensitive
        bool b1 = s1.StartsWith("H");
        if (b1.ToString() == "True")//becuase C#  type safe 
            Console.WriteLine("yes   starts with H");
        else Console.WriteLine("nooooo");
        if (b1.Equals(true)) Console.WriteLine("yes");
        else Console.WriteLine("nnnnnnnnnnnnnnnnnnnnnn");
        // to conver to uupper and lower
        Console.WriteLine(s1.ToUpper());
        Console.WriteLine(s1.ToLower());
        // find index of any character of first occurance
        int n1 = s1.IndexOf("is");
        Console.WriteLine(n1);
        s1.Remove(3, 2);
        string s3 = s1.Insert(6, "Are you");
        Console.WriteLine(s3);
        //  code  to revese  string with help of array reverse()
        //first convert our string to char array
        char[] ch = s1.ToCharArray();// here each character is saved in array
                                     // use foreach 
        foreach (char c in ch.Reverse())
        {
            Console.Write(c); // to display on same line
        }
        Console.WriteLine();
        bool b2 = s1.Contains("K");//checking 
    }
    static void AllDataTypes()
    {
        int n1 = sizeof(int);
        int n2 = sizeof(uint);//unassigned int 
        int n3 = sizeof(sbyte);
        int n4 = int.MaxValue;
        long n5 = long.MinValue;
        Console.WriteLine(n5);
        Console.WriteLine(sizeof(decimal));
    }
    static void Main(string[] args)
    {
        AllStringFuns();
        //    string rashmi = "";
        //    for (int i=0;i <10;i++)
        //    {
        //        rname = rname+i.ToString();
        //        Console.WriteLine( "string class" + rname);// 999  rname 
        //    }
        StringBuilder sb = new StringBuilder(10);
        string result = "";
        for (int i = 0; i < 10; i++)
        {
            sb.Append(i.ToString());
        }

        ////  result = sb.ToString();// memory will 1 sb object only
        ////    Console.WriteLine(result);
        ////
    }
}
}
