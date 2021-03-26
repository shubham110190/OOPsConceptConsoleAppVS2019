using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    class DestrictorTest
    {
        int i = 0;

        public DestrictorTest()
        {
            Console.WriteLine("constrctor calling");
        }

        ~DestrictorTest()
        {

            Console.WriteLine("destrictor calling");
        }
        public void test1(string str)
        {
            Console.WriteLine(str);
        }
    }



    //class TestDestrictorTest
    //{
    //    public static void Main()
    //    {
    //        Console.WriteLine("This is DestrictorTest calling");
    //        DestrictorTest obj1 = new DestrictorTest();
    //        DestrictorTest obj2 = new DestrictorTest();
    //        DestrictorTest obj3 = new DestrictorTest();
    //        obj1 = null;
    //        obj3 = null;
    //        GC.Collect();
    //        Console.ReadLine();
    //    }
    //}


    class TestDestrictorTest: DestrictorTest
    {
        ~TestDestrictorTest()
        {
            Console.WriteLine("destrictor calling TestDestrictorTest");
        }
        //public static void Main()
        //{
        //    Console.WriteLine("This is DestrictorTest calling");
        //    DestrictorTest obj1 = new DestrictorTest();
        //    DestrictorTest obj2 = new DestrictorTest();
        //    DestrictorTest obj3 = new DestrictorTest();
        //    //obj1 = null;
        //    //obj3 = null;
        //    //GC.Collect();

        //    TestDestrictorTest obj4 = new TestDestrictorTest();
        //    Console.ReadLine();
        //}
    }
}
