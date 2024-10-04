using System.Linq.Expressions;
using System.Xml;

namespace S05
{
	public class S05_Class
	{
		public void AgeChecker()
		{
			age:
            Console.Write("Lütfen yaşınızı giriniz: ");
			bool isAge = int.TryParse(Console.ReadLine(), out int age);

			if (!isAge)
			{
                Console.WriteLine("Geçerli bir yaş giriniz!");
				goto age;
			}

            Console.WriteLine($"Tepki: " + (age < 18 ? "-" : "+"));
		}
	}
}
