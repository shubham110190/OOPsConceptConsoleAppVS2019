using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    class SealedTest
    {
        public virtual void Test()
        {
            Console.WriteLine("sealed Test");
        }
    }


    class SealedTest1:SealedTest
    {
        public sealed override void Test()
        {
            Console.WriteLine("sealed Test1");
        }

    }

    class SealedTest2:SealedTest1
    {
        //public override void Test()
        //{
        //    Console.WriteLine("sealed Test");
        //}
    }
}
