using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{

    //Yield keyword isused for stateful itereation
    //custom itereation without temp collection

    class TestYeildKeyword
    {
        static List<int> lst = new List<int>();
        static void ADDItems()
        {
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);

        }
        //caller
        //public static void Main()
        //{
        //    ADDItems();
        //    foreach (int i in FilteredList())
        //    {
        //        Console.WriteLine(i);
        //    }

        //    Console.ReadLine();
        //}

        //wrost case
        //public static List<int> FilteredList()
        //{
        //    List<int> temp = new List<int>();
        //    foreach (int i in lst)
        //    {
        //        if (i > 3)
        //        {
        //            temp.Add(i);

        //        }
        //        Console.WriteLine(i);
        //    }
        //    return temp;

        //}

        //best case
        public static IEnumerable<int> FilteredList()
        {
            int count = 0;
            foreach (int i in lst)
            {
                count += i;
                
                yield return count;

               

            }



            //foreach (int i in lst)
            //{
            //    if (i > 3)
            //    {
            //        yield return i;

            //    }

            //}
        }
    }
}
