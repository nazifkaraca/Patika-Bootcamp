namespace S04
{
	public class S04_Class
	{
		public void RandomRemainder()
		{
			Random rd = new Random();
			int randomNum = rd.Next(3, 100);

            Console.WriteLine($"Rastgele üretilen sayı (3, 100): {randomNum}");
            Console.WriteLine($"Rastgele sayı mod 3: {randomNum % 3}");
		}
	}
}
