// Call every program namespace
using Options;
using S01;
using S02;
using S03;
using S04;
using S05;
using S06;
using S07;
using S08;
using S09;
using S10;
using S11;
using S12;
using S14;
using S15;
using S16;
using S17;
using S18;
using System.ComponentModel;

namespace Week2_6_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call all programs by creating new instance of that class
            S01_Class S01 = new S01_Class();
            S02_Class S02 = new S02_Class();
            S03_Class S03 = new S03_Class();
            S04_Class S04 = new S04_Class();
            S05_Class S05 = new S05_Class();
            S06_Class S06 = new S06_Class();
            S07_Class S07 = new S07_Class();
            S08_Class S08 = new S08_Class();
            S09_Class S09 = new S09_Class();
            S10_Class S10 = new S10_Class();
            S11_Class S11 = new S11_Class();
            S12_Class S12 = new S12_Class();
            S14_Class S14 = new S14_Class();
            S15_Class S15 = new S15_Class();
            S16_Class S16 = new S16_Class();
            S17_Class S17 = new S17_Class();
            S18_Class S18 = new S18_Class();
            aLaCarte Options = new aLaCarte();

            string multiLine = new string('-', 45);
            int choice;

            do
            {
                // Show the menu and get the user's choice
                choice = Options.Menu();

                if (choice == 0)
                {
                    Console.WriteLine("Program is closing...");
                    break; // Exit the loop and close the program
                }

                // Clear screen for better UI
                Console.Clear();

                switch (choice)
                {
                    // 1 - Aşağıdaki çıktıyı yazan bir program.
                    case 1:
                        S01.Greet();
                        break;

                    // 2 - Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayıp, ekrana yazdırınız.
                    case 2:
                        S02.DefineVarible();
                        break;

                    // 3 - Rastgele bir sayı üretip, ekrana yazdırınız.
                    case 3:
                        S03.RandomNum();
                        break;

                    // 4 - Rastgele bir sayı üretip, bunun 3'e bölümünden kalanı ekrana yazdırınız.
                    case 4:
                        S04.RandomRemainder();
                        break;

                    // 5 - Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
                    case 5:
                        S05.AgeChecker();
                        break;

                    // 6 - Ekrana 10 defa "Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
                    case 6:
                        S06.RepetitiveStr();
                        break;

                    // 7 - Kullanıcıdan 2 adet metinsel değer alıp, yerlerini değiştiriniz.
                    case 7:
                        S07.PlaceChanger();
                        break;

                    // 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız.
                    case 8:
                        S08.VoidMethod();
                        break;

                    // 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
                    case 9:
                        Console.WriteLine("Toplam Sonucu: " + S09.Sum());
                        break;

                    // 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
                    case 10:
                        Console.WriteLine(S10.trueFalse());
                        break;

                    // 11 - 3 kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
                    case 11:
                        Console.WriteLine("Yaşı en büyük olan kişi " + S11.DetermineOlder() + " yaşındadır.");
                        break;

                    // 12 - Kullanıcıdan sınırsız sayıda sayı alıp, bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
                    case 12:
                        Console.WriteLine("Yazdığınız sayılardan en büyüğü: " + S12.ReturnMax());
                        break;

                    // 13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
                    case 13:
                        S07.PlaceChanger(); // Does the same thing as case 7
                        break;

                    // 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
                    case 14:
                        Console.WriteLine(S14.OddEven());
                        break;

                    // 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle, gidilen yolu hesaplayan bir metot yazınız.
                    case 15:
                        S15.DistanceCalculator();
                        break;

                    // 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
                    case 16:
                        S16.CircleArea();
                        break;

                    // 17 - "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.
                    case 17:
                        S17.LowerCapital();
                        break;

                    // 18 - "Selamlar" metnini alıp, başındaki ve sonundaki boşlukları siliniz.
                    case 18:
                        S18.StringTrim();
                        break;

                    default:
                        Console.WriteLine("\nGeçersiz seçim, lütfen doğru bir program seçiniz.");
                        break;
                }

                // Wait for user input before returning to the menu
                Console.WriteLine("\n" + multiLine);
                Console.WriteLine("Devam etmek için herhangi bir tuşa basınız...");
                Console.WriteLine(multiLine);
                Console.ReadKey();
                
                // Clear the console screen
                Console.Clear();

            } while (choice != 0); // Loop until the user chooses to exit by entering 0
        }
    }
}
