using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    class TestExtenionMethod1
    {
        int i = 0;
        public void test1(string str)
        {
            Console.WriteLine(str);
        }
    }
    static class TestExtenionMethod
    {
        public static void test1(this TestExtenionMethod1 obj, string str)

        {
            Console.WriteLine("gff");
        }
    }


    class TestExtenionMethod2
    {
        //public static void Main()
        //{
        //    Console.WriteLine("This is extentiomn method calling");
        //    TestExtenionMethod1 objTestExtenionMethod1 = new TestExtenionMethod1();
        //    objTestExtenionMethod1.test1("test1");
        //    //objTestExtenionMethod1.test2("test2 extention method calling");
        //    Console.ReadLine();
        //}
    }
}
