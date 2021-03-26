using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    class TestInheritance1
    {
        string name;
        int age;

        public TestInheritance1()
        {
            Console.WriteLine("Parent constructor");
        }
        public TestInheritance1(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
