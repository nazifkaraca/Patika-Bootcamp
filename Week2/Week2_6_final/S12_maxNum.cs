using System.ComponentModel.Design;

namespace S12
{
	public class S12_Class
	{
        public int ReturnMax()
		{
            Console.Write("Birer boşluk bırakarak dilediğiniz kadar sayı giriniz: ");
			string input = Console.ReadLine();

			string[] numbers = input.Split(' ');

			// Define new list to include inputs as integer
			List<int> output = new List<int>();

			foreach (var number in numbers)
			{
				if (int.TryParse(number, out int result))
				{
					output.Add(result);
				}
				else
					Console.WriteLine($"{result} geçerli bir sayı değil.");
			}

			return output.Max();
        }
    }

}
