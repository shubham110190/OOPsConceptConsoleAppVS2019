using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPsConceptApplication
{
    abstract class TestPerson
    {
      public  string name;
        public int age;

      public  TestPerson(string name, int age) {
            this.name = name;
            this.age = age;
        }
    }

     class Student:TestPerson
    {
        string rollno;
        int marks;

     public Student(string name, int age, string rollno, int marks):base(name,age)
        {
            this.rollno = rollno;
            this.marks = marks;
        }

        //public static void Main() {

        //    Student obj = new Student("shubham", 28, "abc123", 560);
        //    Console.WriteLine(obj.name);
        //    Console.WriteLine(obj.age);
        //    Console.WriteLine(obj.rollno);
        //    Console.WriteLine(obj.marks);
        //    Console.ReadLine();

        //}
    }



}
