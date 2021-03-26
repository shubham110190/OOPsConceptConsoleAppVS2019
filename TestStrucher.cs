using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    //Prove that only 1 instance of the object is created for static classes?
        struct  MyStrucher
        {
        //can not declare parameter less contructor
        // int i =1;
        int i;
        //can not declare parameter less contructor
        //public MyStrucher()
        //{
        //    this.i = 0;
        //}

        public MyStrucher(int i)
        {
            this.i = i;
        }

        public void test1(string str)
        {
            Console.WriteLine(str);


        }

      }

    class TestMyStrucher
    {
        //public static void Main()
        //{
        //    MyStrucher obj = new MyStrucher();//Implicite paraemeterless constructor
        //    obj.test1("test");

        //    MyStrucher obj2 = new MyStrucher(4);//explicit parameterized contructor

        //    Console.ReadLine();
        //}

    }
}
