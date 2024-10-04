using System.Threading.Channels;

namespace S09
{
	public class S09_Class
	{
		public int Sum()
		{
			intCheck:
            Console.Write("Bir sayı giriniz: ");
			bool isNum1 = int.TryParse(Console.ReadLine(), out int x);

			Console.Write("Bir sayı daha giriniz: ");
			bool isNum2 = int.TryParse(Console.ReadLine(), out int y);

			if (!isNum1 || !isNum2)
			{
                Console.WriteLine("Geçerli bir sayı giriniz!");
				goto intCheck;
			}

			return x + y;
		}
	}
}
