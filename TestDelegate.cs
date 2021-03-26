using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{

    public delegate string BindName(string x);
    class TestDelegate
    {
        public string showName(string y)
        {
            Console.WriteLine("called showName");
            return y;
        }

        //public static void Main()
        //{
        //    Console.WriteLine("This is delegateTest calling");
        //    TestDelegate objTestDelegate = new TestDelegate();
        //    BindName obj = new BindName(objTestDelegate.showName);
        //    Console.WriteLine(obj("shubham"));
        //    Console.ReadLine();
        //}


    }
}
