//BASICS FOR C#

// using System.Diagnostics;

using System;

namespace CSarpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            int a = 4;

            String name = "Sara";

            Console.WriteLine("the number is " + a + name);

            Console.WriteLine($"the number is {name}"); // Evaluation String

            var age = 23; //once assigned to a data type, cannot be changed

            dynamic dy = 23.3;  //can be reassigned to different data types
            dy = "hellooo";

                    }


    }

}