using System;

namespace StaticClasses
{
   static class SoftUniMaths
    {  //static class -class -we can not make instances, cariables, objects of teh class 
        // static classes can not be instantiated, all members must be static , otherwise compiler Error
        //static class is sealed -> can not be inherited
        //static class can not ihnerit from other classes, , static members can be accessed through class name
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
        } // Static Method is hung directly to the class, not tot the curr instance
        // MAth, Console, TimeZone
        // Static classes are global, simplify the code, more readble, better perfoamance
    }
}
