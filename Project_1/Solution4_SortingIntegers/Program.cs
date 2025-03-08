namespace Solution4_SortingIntegers
{
    internal class Program
    {
        static void PrintArray(int[] array) {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
        }
        static void QuickSort(int[] array) {
            int pivot = array.Length - 1; //Choose center of the array

        }// End of QuickSort.
        
        
        static void Main(string[] args)
         {
                Console.WriteLine("\nSOLUTION 4: SORTING INTEGERS\n");
                bool continueProgram = true;
                int[] numbers = new int[] { 11, 2, 3, 4, 5, 6, 7, 8, 9, 20,
                                  10, 19, 13, 17, 16, 15, 14, 18, 12, 21 };

                Consoler.WriteLine("The array before sorting is ");
                Program.PrintArray(numbers);
            Console.WriteLine("\n");


            do
            {
                try 
                {
                    //Request input from the user.
                    Console.WriteLine("The original array is: ");
                    foreach (int number in numbers) Console.Write(number + "\t");
                    Console.WriteLine("\n");
                    //Sort the array.
                    Array.Sort(numbers);
                    //Display the sorted array.
                    Console.WriteLine("The sorted array is: ");
                    foreach (int number in numbers) Console.Write(number + "\t");
                    Console.WriteLine("\n");
                    //Prompt if the program should continue.
                    Console.WriteLine("Would you like to continue? (Yes/No)");
                    if (string.Compare(Console.ReadLine(), "YES", StringComparison.OrdinalIgnoreCase) == 0) continueProgram = true;
                    else continueProgram = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }//End of try-catch.
            } while (continueProgram);
        }
    }
}