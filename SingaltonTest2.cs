using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    //why used sealed keyword in class
    class SingaltonTest1
    {
        static int counter = 0;
        static SingaltonTest1 instance = null;

        public static SingaltonTest1 GetInstance
        {

            get
            {
                if (instance == null)
                {
                    instance = new SingaltonTest1();
                    return instance;
                }
                else
                    return instance;

            }
        }
        private SingaltonTest1()
        {
            counter++;
            Console.WriteLine("counter value " + counter);

        }

        public void m1(string m)
        {
            Console.WriteLine(m);
        }

        //nested class
       public class TestSingaltonTest2 : SingaltonTest1
        {
            
        }
    }


    class TestSingaltonTest1
    {
        public static void Main2()
        {
            //SingaltonTest obj = new SingaltonTest();
            //obj.m1("Test1");
            //obj.m1("Test2");

            //Console.WriteLine("/////////////////////////////////////////");

            //SingaltonTest fromEmployeeclass = new SingaltonTest();
            //fromEmployeeclass.m1("fromEmployeeclass");

            //Console.WriteLine("/////////////////////////////////////////");

            //SingaltonTest fromStudentclass = new SingaltonTest();
            //fromStudentclass.m1("fromStudentclass");

            Console.WriteLine("/////////////////////////////////////////");

            SingaltonTest1 fromEmployeeclass = SingaltonTest1.GetInstance;
            fromEmployeeclass.m1("fromEmployeeclass");

           
            SingaltonTest1 fromStudentclass = SingaltonTest1.GetInstance;
            fromStudentclass.m1("fromStudentclass");


            Console.WriteLine("/////////////////////////////////////////");

            SingaltonTest1.TestSingaltonTest2 objTestSingaltonTest2 = new SingaltonTest1.TestSingaltonTest2();

            objTestSingaltonTest2.m1("objTestSingaltonTest2");

            Console.ReadLine();
        }

    }
}
