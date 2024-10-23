using System.Threading.Channels;

namespace Week5_1_array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Declare an array to store 10 integers
            int[] list = new int[10];

            // Use a for loop to get 10 numbers from the user and store them in the array
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write("{0}. Enter the number: ", i + 1);
                list[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Display the numbers entered by the user
            Console.Write("The list you entered: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            // Prompt the user to add the 11th number to the list
            Console.Write("\nEnter the 11th value to add to the array: ");
            int newNumber = Convert.ToInt32(Console.ReadLine());

            // Create a new list to store the numbers
            List<int> numberList = new List<int>();

            // Add the 11th number to the new list
            numberList.Add(newNumber);

            // Add all the numbers from the original array to the new list
            foreach (int number in list)
            {
                numberList.Add(number);
            }

            // Sort the list in ascending order
            numberList.Sort();
            // Reverse the list to make it descending
            numberList.Reverse();

            // Display the list sorted from largest to smallest
            Console.WriteLine("\nList sorted from largest to smallest:");
            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine(); // Pause the console for viewing the output
        }
    }
}
