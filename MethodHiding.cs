using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    class MethodHiding
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

        public string Display(int x, string y)
        {
            Console.WriteLine("Parent Display method");
            return y;
        }

        public void Show(string x, int y)
        {
            Console.WriteLine("Parent Show method");
        }
    }
}
