namespace S15
{
    public class S15_Class
    {
        public void DistanceCalculator()
        {
            checkInt:
                Console.Write("Hız bilgisini giriniz (KM/h): ");
                bool isSpeed = int.TryParse(Console.ReadLine(), out int speed);
            
                Console.Write("Zaman bilgisini giriniz (Saat): ");
                bool isTime = int.TryParse(Console.ReadLine(), out int time);

                if (!isSpeed || !isTime)
                {
                    Console.WriteLine("Lütfen bir sayı giriniz!");
                    goto checkInt;
                }

            Console.WriteLine("Katedilen yol: " + (speed * time));
        }
    }
}

