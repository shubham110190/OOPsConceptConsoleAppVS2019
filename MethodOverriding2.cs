using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    class MethodOverriding2:MethodOverloading
    {
        public void Test(int x, int y)
        {
            Console.WriteLine("Child Test method");
        }

        //public static void Main(string[] args)
        //{
        //    MethodOverriding2 obj = new MethodOverriding2();
        //    obj.Test();
        //    Console.WriteLine(obj.Test(4));
        //    Console.WriteLine(obj.Test(2, "shubham"));
        //    obj.Test("shubham", 2);
        //    obj.Test(4, 2);
        //    Console.ReadLine();
        //}
    }
}
