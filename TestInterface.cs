using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    interface ITestInterface
    {
        void Add(int x, int y);
    }

    //class ITestInterface2:ITestInterface
    //{
    //    void Sub(int x, int y);
    //}

    //class IMplementationTestInterface:ITestInterface
    //{
    //    //public void Add(int x, int y)
    //    //{
    //    //    Console.WriteLine("sf");
    //    //}

    //    void ITestInterface.Add(int x, int y)
    //    {
    //        Console.WriteLine("sf");
    //    }

    //    //public static void Main()
    //    //{
    //    //    IMplementationTestInterface obj = new IMplementationTestInterface();
    //    //    obj.Add(2, 3);
    //    //    Console.ReadLine();
    //    //}
    //}
}
