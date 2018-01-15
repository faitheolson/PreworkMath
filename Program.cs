using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop1 = true;
            bool loop2 = true;
            bool repeat = true;
            int numLength = 0;
            int number1 = 0;
            int number2 = 0;
            char again;
            string string1 = "";
            string string2 = "";
            int[] num1Array = new int[] { };
            int[] num2Array = new int[] { };

            while (repeat == true)
            {
                do
                {
                    Console.WriteLine("Please enter a positive integer:");
                    string1 = (Console.ReadLine());
                    numLength = string1.Length;

                    if (int.TryParse(string1, out number1) && (number1 >= 0))
                    {
                        loop1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry! Please try again!");
                        loop1 = true;
                    }
                } while (loop1 == true);

                do
                {
                    Console.WriteLine("Please enter a second positive integer containing {0} digits:", numLength);
                    string2 = Console.ReadLine();

                    if (int.TryParse(string2, out number2) && (number2 >= 0) && (numLength == string2.Length))
                    {
                        loop2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry! Please try again!");
                        loop2 = true;
                    }

                } while (loop2 == true);


                num1Array = string1.ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
                num2Array = string2.ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

                CompareDigits(num1Array, num2Array);

                Console.WriteLine("Would you like to run program again?");
                again = char.Parse(Console.ReadLine());

                if (again == 'y' || again == 'Y')
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }

            Console.WriteLine("Goodbye!");

        }

        private static void CompareDigits(int [] y , int [] z)
        {
            int[] addition = new int[y.Length];
            for (int i = 0, j = 0; i < y.Length; i++, j++)
            {
                addition[i] = y[i] + z[j];
            }

            bool bothSame = Array.TrueForAll(addition, x => x == addition[0]);
            Console.WriteLine(bothSame + "!");
        }



    }
}
