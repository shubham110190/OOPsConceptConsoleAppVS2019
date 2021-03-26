using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    class MetHidingaOverridisngaoverloding: MethodHidingandOverridisngandoverloding
    {
        public int Test(int x, int y)//inheritance based overloding
        {
            Console.WriteLine("Child Test method");
            return x+y;
        }
        public new void Display(int x, string y)//method hiding or showding
        {
            Console.WriteLine("Child Display method");
        }
        //using virtual keyword we have given permission to user reimplement the method with same singnature and name even you can not change return type
        public override void Show(string x, int y)// overriding
        {
            Console.WriteLine("Child Show method");
        }

        //public static void Main(string[] args)
        //{

        //    MetHidingaOverridisngaoverloding obj = new MetHidingaOverridisngaoverloding();
        //    Console.WriteLine("/////////////////  start overloading    //////////////////////////////");
        //    obj.Test();//overloding
        //    Console.WriteLine(obj.Test(4));//overloding
        //    Console.WriteLine(obj.Test(4, 6));//overloding
        //    Console.WriteLine("////////////////////// end overloading    /////////////////////////");
        //    Console.WriteLine("/////////////////  start overridding    //////////////////////////////");
        //    obj.Show("shubham1", 2);
        //    obj.Display(4, "shubham2");
        //    Console.WriteLine("///////////////////////////////////////////////");
        //    //obj.PShow("shubham3", 2);
        //    Console.WriteLine("///////////////////////////////////////////////");
        //    //parent class refrence
        //    MethodHidingandOverridisngandoverloding objp = obj;

        //    objp.Show("shubham", 2);//call child method
        //    objp.Display(4, "shubham2");//call parent method


        //    Console.WriteLine("///////////////////////////////////////////////");
        //    Console.ReadLine();
        //}
    }
}
