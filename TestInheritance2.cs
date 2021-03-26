using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    class TestInheritance2:TestInheritance1
    {
        string rollno;
        int marks;

        public TestInheritance2()
        {
            Console.WriteLine("Child constructor");
        }

        public TestInheritance2(int marks, string rollno, int age, string name) : base(age, name)
        {
            this.rollno = rollno;
            this.marks = marks;
        }

    }
}
