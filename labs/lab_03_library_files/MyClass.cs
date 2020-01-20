using System;

namespace lab_03_library_files
{

    // Class is a container
    public class MyClass
    {
        // method (function)
        public int DoubleUp(int number)
        {
            return 2 * number;
        }

        // field
        public double GravitationalConstant = 9.81;

        //Static equivalent: Read directly from the class
        public static int AlsoTripleUp(int number)
        {
            return 3 * number;
        }
        //field
        public static double NaturalLogarithmE = 2.71;
    }
}
