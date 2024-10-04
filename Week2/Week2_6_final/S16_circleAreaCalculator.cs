namespace S16
{
    public class S16_Class
    {
	    public void CircleArea()
	    {
            {
                Console.Write("Dairenin yarıçapını cm cinsinden giriniz: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                // Circle area calculation
                double area = Math.PI * Math.Pow(radius, 2);

                Console.WriteLine("Dairenin alanı: " + Math.Round(area, 2) + " cm²");
            }
        }
    }

}
