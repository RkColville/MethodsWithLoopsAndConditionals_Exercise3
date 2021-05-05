using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // All my methods are below. I can uncomment to check each one!
            //Counter();
            //NumbersByThree();
            //TwoIntsEqual(20, 20);
            //NumEvenOrOdd(12);
            //PositiveOrNegative(-1);
            //CandidateAge();
            //IntegerInRange();
            MultTable();


            Console.ReadLine();
        }

        // Write a method to display the multiplication table(from 1 to 12) of a given integer.
        public static void MultTable()
        {
            Console.WriteLine("Please provied any interger.");
            int num1 = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine(i * num1);
            }
            
            
        }

        // Write a method to check if an integer(from the user) is in the range -10 to 10.

        public static void IntegerInRange()
        {
            Console.WriteLine("Enter a number between -10 and 10.");
            int num = int.Parse(Console.ReadLine());

            if (num >= -10 && num <= 10)
            {
                Console.WriteLine("Your number is within our -10 and 10 range.");
            }
            else
            {
                Console.WriteLine("Your number is out of range");
            }


        }

        //Write a method to read the age of a candidate and determine whether they 
        //can vote.Hint: use Parse()... or the safer TryParse() for an extra challenge!!

        public static void CandidateAge()
        {
            Console.WriteLine("What is your age?");
            var age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote");
            }
            else if (age <= 17)
            {
                Console.WriteLine("You are too young to vote.");
            }
        }



        //Write a method to check whether a given number is positive or negative.

        public static void PositiveOrNegative(int num)
        {
            
            if (num == 0 )
            {
                Console.WriteLine("Number is zero");
            }
            else if (num > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

            
        }

        //Write a method to check whether a given number is even or odd.
        public static void NumEvenOrOdd(int num)
        {
            
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }   

        // Write a method to accept two intergers as parameters and check
        // whether they are equal or not.
        public static bool TwoIntsEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Write a method that will print to the console numbers 3
        // through 999 by 3 each time.

        public static void NumbersByThree()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print
        //to the console all numbers 1000 through -1000.

        public static void Counter()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }



        

    }
}
