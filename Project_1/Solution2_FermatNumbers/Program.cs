using System.Numerics;

namespace Solution2_FermatNumbers
{
    internal class Program
    {
        static void NthFermatNumber(int n) 
        {
            BigInteger FermatNumber = BigInteger.Parse("3");
            //Console.WriteLine(FermatNumber + "\t");

            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    //Console.WriteLine("i = " + i);
                    FermatNumber = FermatNumber - BigInteger.Parse("1");
                    //Console.Write(FermatNumber + "\t");
                    FermatNumber = (FermatNumber * FermatNumber) + BigInteger.Parse("1");
                    //Console.WriteLine(FermatNumber + "\t");
                }
            }
            
            Console.WriteLine("The Fermat number number " + (n+1) + " is " + FermatNumber + ".");
            
        }
        static void Main(string[] args)
        {
            bool continueProgram = true;
            int n = 0;

            Console.WriteLine("FERMAT NUMBERS CALCULATOR\n");
            //Information capture
            do { 
                try
                {
                    //Request input from user.
                    Console.WriteLine("Please enter a positive integer representing the n-th Fermat number:");
                    n = int.Parse(Console.ReadLine());

                    //Determine if the input is valid.
                    if (n < 1) Console.WriteLine("\nERROR: " + n + " is not a valid input.");
                    else Program.NthFermatNumber(n-1);

                    //Ask user if program should continue.
                    Console.WriteLine("\nWould you like to continue? (Yes/No)");
                    if (string.Compare(Console.ReadLine(), "YES", StringComparison.OrdinalIgnoreCase) == 0) continueProgram = true;
                    else continueProgram = false;
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.ToString());
                    return;
                }

            }
            while (continueProgram);
            
        }
    }
}
