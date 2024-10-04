using System.Diagnostics.Metrics;
using System.Numerics;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Options
{
	public class aLaCarte
	{
		string multiLine = new string('-', 40);

        public int Menu()
		{
            isMenu:
            Console.WriteLine(multiLine);

            Console.WriteLine("Nazif'in İşlevler Menüsüne Hoş Geldiniz!");
            Console.WriteLine("Burada aşağıdaki işlevlerden birini sayısını belirterek kullanabilirsiniz: ");

            Console.WriteLine("(1) GreetLoop – Kullanıcıya sırayla \"Merhaba, Nasılsın?\" ve cevaplarını yazdıran program.");
            Console.WriteLine("(2) VarDisplay – Bir metinsel ve bir tam sayı değişkeni tanımlayıp, değerlerini ekrana yazdırır.");
            Console.WriteLine("(3) RandomPop – Rastgele bir sayı üretir ve ekrana yazdırır.");
            Console.WriteLine("(4) ModBuzz – Rastgele bir sayıyı 3'e böler ve kalanını ekrana yazdırır.");
            Console.WriteLine("(5) AgeCheck – Kullanıcının yaşını alır, 18'den büyükse \"+\", değilse \"-\" işaretini gösterir.");
            Console.WriteLine("(6) VodafoneLoop – Ekrana 10 defa \"Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.\" yazdırır.");
            Console.WriteLine("(7) SwapNames – Kullanıcıdan iki isim alır ve bunların yerini değiştirir.");
            Console.WriteLine("(8) NoReturn – Ekrana \"Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma\" yazdırır.");
            Console.WriteLine("(9) SumUp – İki sayıyı alır ve toplamını döndürür.");
            Console.WriteLine("(10) TruthCall – Kullanıcıdan true/false değeri alır ve string bir sonuç döndürür.");
            Console.WriteLine("(11) ElderlyCheck – 3 kişinin yaşını alır ve en yaşlı olanı bulur.");
            Console.WriteLine("(12) MaxFinder – Kullanıcıdan sınırsız sayıda sayı alır ve en büyüğünü bulup ekrana yazdırır.");
            Console.WriteLine("(13) NameSwitcher – Kullanıcıdan alınan iki ismin yerini değiştiren metot.");
            Console.WriteLine("(14) OddOrEven – Kullanıcıdan alınan sayının tek mi çift mi olduğunu döner.");
            Console.WriteLine("(15) SpeedPath – Kullanıcıdan hız ve zaman alır, gidilen yolu hesaplar.");
            Console.WriteLine("(16) CircleCalc – Verilen yarıçap ile dairenin alanını hesaplar.");
            Console.WriteLine("(17) CapsLock – \"Zaman bir geri sayım\" cümlesini büyük harf ve küçük harflerle yazdırır.");
            Console.WriteLine("(18) TrimIt – \"Selamlar\" metnini alır, başındaki ve sonundaki boşlukları temizler.\n");
            Console.WriteLine("(0) Quit – Programı kapatmak için 0 yazınız.\n");

            Console.WriteLine(multiLine);

            Console.Write("Seçiminizi sayı olarak belirtiniz: ");
            bool isNum = int.TryParse(Console.ReadLine(), out int choice);

            if (!isNum)
            {
                Console.Clear();
                Console.WriteLine("\n" + multiLine); 
                Console.WriteLine("Geçerli bir program seçiniz! Devam etmek için bir tuşa basın.");
                Console.WriteLine(multiLine); 
                Console.ReadKey();
                // Clear screen
                Console.Clear();
                goto isMenu;
            }

            return choice;
		}
	}

}
