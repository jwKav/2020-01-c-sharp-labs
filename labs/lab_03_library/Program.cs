using System;
using lab_03_library_files;

namespace lab_03_use_library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is going to call and use a library");

            //OOP: New instance to talk to our class

            var myinstance = new MyClass();

            //myinstance.DoubleUp(10);
            //myinstance.GravitationalConstant;

            Console.WriteLine(myinstance.DoubleUp(10));
            Console.WriteLine(myinstance.GravitationalConstant);

            Console.WriteLine("Now reference STATIC items");
            Console.WriteLine(MyClass.AlsoTripleUp(10));
            Console.WriteLine(MyClass.NaturalLogarithmE);
           

        }
    }
}
