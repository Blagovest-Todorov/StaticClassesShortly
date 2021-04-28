using System;

namespace StaticClasses
{
   static class SoftUniMaths
    {  //static class -class -we cannot make instances, variables, objects of the class 
        // static classes cannot be instantiated, all members must be static , otherwise compiler Error
        //static class is sealed -> can not be inherited
        //static class can not inherit from other classes, static members can be accessed through class name
        static void Main(string[] args)
        {
            
            Console.WriteLine(SoftUniMaths.Add(5, 6));
        }

        public static int Add(int a, int b)  
        {
            return a + b;
        }
        public static int multiply(int a, int b) 
        {
            return a * b;
        } // Static Method is hung directly to the class, not to the curr instance
        // MAth, Console, TimeZone
        // Static classes are global, simplify the code, more readable, better performance
    }
}
