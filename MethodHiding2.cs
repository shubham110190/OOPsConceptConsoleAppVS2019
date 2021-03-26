using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    class MethodHiding2:MethodHiding
    {
        public new string Display(int x, string y)
        {
            Console.WriteLine("child display method");
            return y;
        }

        public new void Show(string x, int y)
        {
            Console.WriteLine("child Show method");
        }

        public string PDisplay(int x, string y)
        {
            Console.WriteLine("Pchild display method");
            return y;
        }

        public void PShow(string x, int y)
        {
            Console.WriteLine("Pchild Show method");
            base.Show(x, y);
        }


        //public static void Main(string[] args)
        //{

        //    MethodHiding2 obj = new MethodHiding2();
        //    //obj.Test();
        //    //Console.WriteLine(obj.Test(4));
        //    //obj.Show("shubham1", 2);
        //    //obj.Display(4, "shubham2");
        //    //Console.WriteLine("///////////////////////////////////////////////");
        //    //obj.PShow("shubham3", 2);
        //    Console.WriteLine("///////////////////////////////////////////////");
        //    //parent class refrence
        //    MethodHiding objp = obj;

        //    objp.Show("shubham", 2);//call parent method
        //    objp.Display(4, "shubham2");//call parent method
        //    Console.WriteLine("///////////////////////////////////////////////");
        //    Console.ReadLine();
        //}
    }
}
