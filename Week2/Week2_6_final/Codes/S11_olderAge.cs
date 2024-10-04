namespace S11
{
	public class S11_Class
	{
		public int DetermineOlder()
		{
            isThisAge:
            Console.Write("Birinci kişinin yaşını giriniz: ");
			bool isAge = int.TryParse(Console.ReadLine(), out int age);

            Console.Write("İkinci kişinin yaşını giriniz: ");
			bool isAge2 = int.TryParse(Console.ReadLine(), out int age2);

            Console.Write("Üçüncü kişinin yaşını giriniz: ");
			bool isAge3 = int.TryParse(Console.ReadLine(), out int age3);

			if (!isAge || !isAge2 || !isAge3)
			{
                Console.WriteLine("Lütfen bir yaş giriniz!");
				goto isThisAge;
			}

			return Math.Max(age, Math.Max(age2, age3));
		}
	}

}
