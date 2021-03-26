using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    class MethodOverloading
    {

        public void Test()
        {
            Console.WriteLine("Parent Test method1");
        }

        public int Test(int x)
        {
            Console.WriteLine("Parent Test method2");
            return x;
        }

        public string Test(int x, string y)
        {
            Console.WriteLine("Parent Test method3");
            return y;
        }

        public void Test(string x, int y)
        {
            Console.WriteLine("Parent Test method4");
        }

        //public static void Main(string[] args)
        //{
        //    MethodOverloading obj = new MethodOverloading();
        //    obj.Test();
        //   Console.WriteLine(obj.Test(4));
        //   Console.WriteLine(obj.Test(2,"shubham"));
        //    obj.Test("shubham",2);
        //    Console.ReadLine();
        //}
    }
}
