namespace S17
{
    public class S17_Class
    {
        public void LowerCapital()
        {
            {
                string s = "Zaman bir GeRi SayIm";

                Console.WriteLine($"Girilen değer: \"{s}\"");
                Console.WriteLine($"Hepsi büyük hali " + s.ToUpper());
                Console.WriteLine($"Hepsi küçük hali " + s.ToLower());
            }
        }
    }

}
