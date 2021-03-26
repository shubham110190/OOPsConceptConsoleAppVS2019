using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
   abstract class TestAreaAbstract
    {
        public double height, width,radious;
        public double pi = 3.14;
        public abstract double GetArea();
        public abstract double GetParameter();
    }

    class circule : TestAreaAbstract
    {
        public circule(double radious)
        {
            this.radious = radious;
        }

        public override double GetArea()
        {
            return 2 * pi * radious; 
        }

        public override double GetParameter()
        {
            return pi * radious * radious;
        }
    }

    class Rectangle : TestAreaAbstract
    {
        public Rectangle(double heigth, double width)
        {
            this.height = heigth;
            this.width = width;
        }

        public override double GetArea()
        {
            return width*height;
        }

        public override double GetParameter()
        {
            return 2*(width + height);
        }
    }

    class TestFig
    {
        //public static void Main()
        //{
        //    Rectangle robj = new Rectangle(10,20);
        //    Console.WriteLine(robj.GetArea());
        //    Console.WriteLine(robj.GetParameter());

        //    Console.WriteLine("//////////////////////////////////////////");

        //    circule cobj = new circule(10.5);
        //    Console.WriteLine(cobj.GetArea());
        //    Console.WriteLine(cobj.GetParameter());

        //    Console.ReadLine();

        //}
    }
}
