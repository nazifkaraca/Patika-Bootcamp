namespace Week5_2_list2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] coffeeList = new string[5];

            for (int i = 0; i < coffeeList.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Kahve {0}: ", i+1);

                Console.ForegroundColor = ConsoleColor.Green;
                coffeeList[i] = Console.ReadLine();
            }

            Console.ResetColor();

            Console.WriteLine("Girilen Kahve İsimleri:");

            foreach (string coffee in coffeeList)
            {
                Console.WriteLine(coffee);
            }

        }
    }
}
