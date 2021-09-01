using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_one
{
    class Program
    {
        static void Main(string[] args)
        {

            SampleCode();

            Console.ReadKey();
        }

        static void SampleCode()
        {
            //Learning the writeline command
            Console.WriteLine("Hello Ninja!");
            Console.WriteLine("Hello " + "Ninja!");
            Console.Write("What is your name? ");
            string yourName = Console.ReadLine();
            Console.WriteLine($"Hello {yourName}.");

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

            Console.Write("How many hours of sleep did you get last nite? ");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if (hoursOfSleep < 8)
            {
                if (hoursOfSleep >= 6)
                {
                    Console.WriteLine("Not bad, but you need more.");
                }
                else if (hoursOfSleep < 6)
                {
                    Console.WriteLine("Dude you need more sleep.");
                }
                else
                {
                    Console.WriteLine("I don't know what you wrote.");
                }
            }
            else
            {
                Console.WriteLine("Good job. That's a lot of sleep.");
            }
            
        }
        static void DataTypes()
        {
            int yourAge= 102; //int is a whole number positve or negitive.
            char yourGrade = 'B'; //Chars are string for just one letter but still strings.
            float myFloat = 12.3f; // f is required to be labeled with said f for fractions with 7 point presision numbers.
            decimal myDecimal = 30.3312312313213213213m;//decimal has a 21 precision numbers and needs a m to function.
            double myDouble = 12.1234567891011121314151617181920;//double is has 15 precision.
            bool myboolean = true; //has to be true or false
            string myString = "hello";//strings are text and need to be inside of a "" or a ''.

            var testCasting = myDecimal + yourAge;
            var something = 12;
            Console.WriteLine($"{testCasting}");

            ///Math Operators
            /// + - / * %
            ///


            double num1 = 5;
            double num2 = 7;
            double num3 = 11;
            double num4 = 12;

            //addition
            num1 + num2;
            //subtraction
            num2-num4
            //Division
            num2/num3
            //Multi
            num3*num2
            //percent











        }
    }
}