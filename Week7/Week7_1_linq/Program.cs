namespace Week7_1_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> list = new List<int>();
            
            // Generate 10 random number and assign them to list
            for (int i = 0; i < 10; i++) list.Add(random.Next(-100, 101));

            #region EvenNumbers
            // Q1 Even numbers
            Console.WriteLine("Çift sayılar:");

            // Get only even numbers from list and assign them to evenNumbers
            var evenNumbers = list.Where(num => num % 2 == 0);
            // Loop through 
            foreach (int num in evenNumbers) Console.WriteLine(num); 
            #endregion

            Console.WriteLine("--------------");

            #region OddNumbers
            // Q2 Odd numbers
            Console.WriteLine("Tek sayılar:");

            var oddNumbers = list.Where(num => num % 2 != 0);

            foreach (var num in oddNumbers) Console.WriteLine(num); 
            #endregion

            Console.WriteLine("--------------");

            #region NegativeNumbers
            // Q3 Negative numbers
            Console.WriteLine("Negatif sayılar:");

            var negativeNumbers = list.Where(num => int.IsNegative(num));

            foreach (var num in negativeNumbers) Console.WriteLine(num);
            #endregion

            Console.WriteLine("--------------");

            #region PositiveNumbers
            Console.WriteLine("Pozitif sayılar:");

            var positiveNumbers = list.Where(num => int.IsPositive(num));

            foreach (int num in positiveNumbers) Console.WriteLine(num);
            #endregion

            Console.WriteLine("--------------");

            #region GreaterSmaller
            Console.WriteLine("15'ten büyük 22'den küçük sayılar:");

            var greaterSmaller = list.Where(num => num > 15 && num < 22);

            foreach (int num in greaterSmaller) Console.WriteLine(num);

            #endregion

            Console.WriteLine("--------------");

            #region Power
            Console.WriteLine("Her sayının karesi: ");
            // Take 2 to the power of a number
            list.ForEach(num => Console.WriteLine($"{num} --> " + Math.Pow(num, 2)));

            #endregion
        }
    }
}
