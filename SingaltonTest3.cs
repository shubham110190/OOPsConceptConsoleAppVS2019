using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    sealed class SingaltonTest3
    {
        static int counter = 0;
        static SingaltonTest3 instance = null;
        static readonly object obj = new object();
        public static SingaltonTest3 GetInstance
        {

            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new SingaltonTest3();
                            
                        }
                        
                    }
                }
                return instance;

            }
        }
        private SingaltonTest3()
        {
            counter++;
            Console.WriteLine("counter value " + counter);

        }

        public void m1(string m)
        {
            Console.WriteLine(m);
        }
    }


    class TestSingalton3Test
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
        //    //it voilates the rule of singalton (in multithreading);
        //    Console.WriteLine("/////////////////////////////////////////");
        //    Parallel.Invoke(
        //        ()=>                
        //    EmployeeM(),()=>
        //    StudentM());
        //    Console.WriteLine("/////////////////////////////////////////");         
        //    Console.ReadLine();
        //}

        private static void EmployeeM()
        {
            SingaltonTest3 fromEmployeeclass = SingaltonTest3.GetInstance;
            fromEmployeeclass.m1("fromEmployeeclass");
        }

        private static void StudentM()
        {
            SingaltonTest3 fromStudentclass = SingaltonTest3.GetInstance;
            fromStudentclass.m1("fromStudentclass");
        }
    }
}
