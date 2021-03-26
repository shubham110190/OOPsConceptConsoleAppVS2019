using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    //Prove that only 1 instance of the object is created for static classes?
    static class TestStaticClass
    {
        static int count = 0;
        static TestStaticClass()
        {
            count++;
        }

        public static void test1(string str)
        {
            Console.WriteLine(str+" "+count);
        }
    }

    class TestStaticClass1
    {
        //public static void Main()
        //{
        //    TestStaticClass.test1("shubham");
        //    TestStaticClass.test1("lucky");
        //    //foreach (int i in FilteredList())
        //    //{
        //    //    Console.WriteLine(i);
        //    //}

        //    Console.ReadLine();
        //}

    }
}
