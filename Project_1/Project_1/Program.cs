using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static bool DivisibilityTest(int firstOperand, int secondOperand)
        {
            bool result = false;

            if (firstOperand % secondOperand == 0) result = true;
            else result = false;

            return result;
        }

        static void PrintArrayBool(bool[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");

            }
            Console.WriteLine("");
        }

        static void ListOfPrimes( int n)
        {
            bool itsInteger = false;
            
            Console.WriteLine("The list of primes present in integers up to number " + n + " are:");
            for (int i = 2;  i <= n; i++) //List of numbers from 1 to n
            {
                itsInteger = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) itsInteger = false;
                }
                
                if (itsInteger) Console.Write(i + "\t");
            }
            Console.Write("\n");
        }

        /*static bool[] ListOfPrimes(int n)
        {
            bool[] primes = new bool[n];

            primes[0] = false; //1 is not a prime number
            primes[1] = true; //2 is a prime number
            //Console.Write("1\t2\t");

            for (int i = 2; i < primes.Length; i++)
            {
                //Console.Write((i + 1) + "\t");
                primes[i] = true;
            }
            Console.WriteLine("");
            // Program.PrintArrayBool(primes);

            //Sieve of Eratosthenes method
            for (int i = 1; i < primes.Length; i++)
            {
                if (primes[i]) //If a number is prime we tested.
                {
                    //Console.WriteLine("Current prime = " + (i + 1));
                    //Confirm if i is indeed a prime
                    for (int j = 1; j < i; j++)
                    {
                        if ((i + 1) % (j + 1) == 0) primes[i] = false;
                    }
                    //Program.PrintArrayBool(primes);
                }
                if (primes[i])  //If i+1 is indeed a prime find all its multiples up to n.
                {
                    int numberOfMultiples = primes.Length / (i + 1);
                    for (int j = 2; j < numberOfMultiples; j++)
                    {
                        primes[(j * (i + 1) - 1)] = false;
                    }
                }
                //Program.PrintArrayBool(primes);
            }//End of for

            //Displaying result
            for (int k = 0; k < primes.Length; k++)
            {
                if (primes[k]) Console.Write((k + 1) + "\t");
            }
            Console.WriteLine("");

            return primes;
        }*/
        static void Main(string[] args)
        {
            int firstOperand = 0;
            int secondOperand = 0;
            bool keepRunning = true;
            Console.WriteLine("CHECKING DIVISIBILITY OF TWO INTEGERS");

            do
            {
                //READ INFORMATION FROM THE USER
                try
                {
                    Console.WriteLine("Please input the first integer:");
                    firstOperand = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please input the second operand:");
                    secondOperand = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }

                //TESTING FOR DIVISIBILITY OF THE FIRST INTEGER BY THE SECOND INTEGER
                if (Program.DivisibilityTest(firstOperand, secondOperand))
                {
                    Console.WriteLine("The number " + firstOperand + " is divisible by " + secondOperand + ".");
                }
                else Console.WriteLine("The number " + firstOperand + " is not divisible by " + secondOperand + ".");

                //FINDING ALL THE PRIME NUMBER BELOW THE FIRST INPUT
                Program.ListOfPrimes(firstOperand);

                try
                {
                    Console.WriteLine("Would you like to continue the program? Write yes to continue.");
                    if (string.Compare(Console.ReadLine(), "YES", StringComparison.OrdinalIgnoreCase) == 0) keepRunning = true;
                    else keepRunning = false;
                }
                catch (Exception e) { Console.WriteLine(e.ToString()); return; }
            } while (keepRunning);
        }
    }
}
