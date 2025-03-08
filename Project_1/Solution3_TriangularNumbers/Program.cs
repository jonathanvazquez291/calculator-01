namespace Solution3_TriangularNumbers
{
    internal class Program
    {
        /*Triangular Numbers
         * The nth triangular number is the number of dots in the triangular 
         * arrangement with n dots on each side, and is equal to the sum of 
         * the n natural numbers from 1 to n.
        */
        static void TriangularNumberList(int n)
        {
            Console.WriteLine("The triangular numbers up to "+n+" are: ");
            int triangularNumber = 0;
            int i = 0;
            do
            {
                Console.Write(triangularNumber + "\t");
                i++;
                triangularNumber += i;

            }
            while (triangularNumber < n);
        }
        static void Main(string[] args)
        {
            bool continueProgram = true;
            int n; //Value to which triangular numbers will be calculated.
            do
            {
                try {
                    //Request input from the user.
                    Console.WriteLine("\nTRIANGULAR NUMBER CALCULATOR");
                    Console.WriteLine("Please enter a positive integer representing the up to which the triangular numbers will be comouted:");

                    n = int.Parse(Console.ReadLine());
                    if (n>-1) TriangularNumberList(n);
                    else Console.WriteLine("\nERROR: " + n + " is not a valid input.");

                    //Prompt if program should continue.
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
