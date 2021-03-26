using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    class MethodOverridding2:MethodOverridding
    {
        //overriden member
        public override void Show(string x, int y)
        {
            Console.WriteLine("Child Show method");
       
        }

        public  void ShowChild()
        {
            Console.WriteLine("ShowChild method");
        }

        //public static void Main(string[] args)
        //{
        //    MethodOverridding2 obj = new MethodOverridding2();
        //    obj.Test();
        //    Console.WriteLine(obj.Test(4));
        //    obj.Show("shubham", 2);
        //    //parent class refrence
        //    MethodOverridding objp = obj;
        //    objp.Show("shubham", 2);
        //    Console.ReadLine();
        //}
    }
}
