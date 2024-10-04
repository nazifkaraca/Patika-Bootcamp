namespace S07
{
	public class S07_Class
	{
		public void PlaceChanger()
		{
            Console.Write("İlk metini giriniz: ");
			string string1 = Console.ReadLine();

            Console.Write("İkinci metini giriniz: ");
            string string2 = Console.ReadLine();

            string tempStr = string1;
            string1 = string2;
			string2 = tempStr;

            Console.WriteLine("Yeri değiştirilmiş ilk metin: " + string1);
            Console.WriteLine("Yeri değiştirilmiş ikinci metin: " + string2);

		}
	}
}
