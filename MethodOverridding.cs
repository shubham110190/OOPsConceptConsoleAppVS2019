﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    class MethodOverridding
    {
        public void Test()
        {
            Console.WriteLine("Parent Test method1");
        }

        public int Test(int x)
        {
            Console.WriteLine("Parent Test method2");
            return x;
        }

        public string Display(int x, string y)
        {
            Console.WriteLine("Parent Test method3");
            return y;
        }
        //using virtual keyword we have given permission to user reimplement the method with same singnature and name even you can not change return type
        public virtual void Show(string x, int y)
        {
            Console.WriteLine("Parent Show method");
        }
       
    }
}
