using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class formatters
    {
        static void Main(string[] args)
        {
            //string interpolation
            int age = 30;
            string name = "Veeral";
            string message = $"Hello, my name is {name} and I am {age} years old.";
            Console.WriteLine(message);
            Console.ReadLine();
            //example of string.format
            int age1 = 30;
            string name1 = "Veeral";
            string message1 = string.Format("Hello, my name is {0} and I am {1} years old.", name1, age1);
            Console.WriteLine(message1);
            Console.ReadLine();
            
            //example of Numeric format strings
            double number = 12345.6789;

            // Currency format
            string currency = number.ToString("C");
            Console.WriteLine(currency); 

            // Fixed-point format
            string fixedPoint = number.ToString("F2");
            Console.WriteLine(fixedPoint);

            // Exponential format
            string exponential = number.ToString("E2");
            Console.WriteLine(exponential);
            Console.ReadLine() ;

            //example of standard date and time settings
            DateTime now = DateTime.Now;

            // Long date pattern
            string longDate = now.ToString("D");
            Console.WriteLine(longDate); 

            // Short date pattern
            string shortDate = now.ToString("d");
            Console.WriteLine(shortDate); 

            // Full date/time pattern (short time)
            string fullDateTime = now.ToString("f");
            Console.WriteLine(fullDateTime); 

            // Custom date and time format
            string customFormat = now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(customFormat); 



        }
    }
}
