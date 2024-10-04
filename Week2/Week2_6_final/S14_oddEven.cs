namespace S14
{
	public class S14_Class
	{
		public string OddEven()
		{
			checkInt:
            Console.Write("Bir sayı giriniz: ");
			bool isInt = int.TryParse(Console.ReadLine(), out int input);

			if (!isInt)
			{
				Console.WriteLine("Lütfen bir sayı giriniz!");
				goto checkInt;
			}

			return input % 2 == 0 ? "true" : "false";
		}
	}
}
