namespace S03
{
	public class S03_Class
	{
		public void RandomNum()
		{
			Random random = new Random();
			int randomNum = random.Next(0, 100);

            Console.WriteLine($"Rastgele bir sayı üretildi (0-100): {randomNum}"); 
		}
	}

}
