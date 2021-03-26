using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
   sealed class SingaltonTest
    {
        static int counter = 0;
        static SingaltonTest instance = null;

        public static SingaltonTest GetInstance
        {

            get
            {
                if (instance == null)
                {
                    instance= new SingaltonTest();
                    return instance;
                }
                else
                    return instance;
                    
            }
        }
        private SingaltonTest()
        {
            counter++;
            Console.WriteLine("counter value "+ counter);

        }

        public void m1(string m)
        {
            Console.WriteLine(m);
        }
    }


    class TestSingaltonTest
    {
        //public static void Main()
        //{
        //    //SingaltonTest obj = new SingaltonTest();
        //    //obj.m1("Test1");
        //    //obj.m1("Test2");

        //    //Console.WriteLine("/////////////////////////////////////////");

        //    //SingaltonTest fromEmployeeclass = new SingaltonTest();
        //    //fromEmployeeclass.m1("fromEmployeeclass");

        //    //Console.WriteLine("/////////////////////////////////////////");

        //    //SingaltonTest fromStudentclass = new SingaltonTest();
        //    //fromStudentclass.m1("fromStudentclass");

        //    Console.WriteLine("/////////////////////////////////////////");

        //    SingaltonTest fromEmployeeclass = SingaltonTest.GetInstance;
        //    fromEmployeeclass.m1("fromEmployeeclass");

        //    Console.WriteLine("/////////////////////////////////////////");

        //    SingaltonTest fromStudentclass = SingaltonTest.GetInstance;
        //    fromStudentclass.m1("fromStudentclass");

        //    Console.ReadLine();
        //}

    }
}
