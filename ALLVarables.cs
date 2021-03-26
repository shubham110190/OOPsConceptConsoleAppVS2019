using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    class ALLVarables
    {

        static int x = 100;
        int y = 200;
        const float z = 5.6f;
        readonly int w;
        public ALLVarables(int x) {
            this.y = x;
            this.w = x;
        }
        public void TestMethod()
        {
            Console.WriteLine(x);
            Console.ReadLine();
        }
        //public static void Main()
        //{
        //    Console.WriteLine(x);
        //    x = 300;
        //    Console.WriteLine(x);
        //    ALLVarables objAllVar = new ALLVarables(20);
        //    Console.WriteLine(objAllVar.y);
        //    ALLVarables objAllVar2 = new ALLVarables(30);
        //    Console.WriteLine(objAllVar2.y);
        //    Console.WriteLine(z);           
        //    Console.ReadLine();
        //}
    }
}
