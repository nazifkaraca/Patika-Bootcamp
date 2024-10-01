using System;

namespace Week1Last
{
    class Program
    {
        public static void Main(string[] args)
        {   
            // Hello World program
            Console.WriteLine("Hello World!");


            // Sum of integers
            Console.Write("Sayı girin:");
            string number1_str = Console.ReadLine();

            Console.Write("Sayı girin:");
            string number2_str = Console.ReadLine();

            if (int.TryParse(number1_str, out int number1) && int.TryParse(number2_str, out int number2))
            {
                Console.WriteLine($"Sonuç: {number1 + number2}" );
            }
            else
            {
                Console.WriteLine("Lütfen sayı giriniz.");
            }
            

            // Age check
            Console.Write("Yaşınızı girin: ");
            string age_str = Console.ReadLine();

            if (int.TryParse(age_str, out int age))
            {
                if (age > 18)
                {
                    Console.WriteLine("Yetişkinsiniz");
                }
                else
                {
                    Console.WriteLine("Çocuksunuz");
                }
            }
            else
            {
                Console.WriteLine("Lütfen sayı giriniz.");
            }
            

            // Even Odd
            Console.Write("Bir tamsayı girin: ");
            string evenodd_str = Console.ReadLine();

            if (int.TryParse(evenodd_str, out int evenodd))
            {
                if (evenodd % 2 == 0)
                {
                    Console.WriteLine("Çift sayıdır.");
                }
                else
                {
                    Console.WriteLine("Tek sayıdır.");
                }
            }
            else
            {
                Console.WriteLine("Lütfen sayı giriniz.");
            }


            // Celcius
            Console.Write("Bir sıcaklık değeri girin (Celcius): ");
            string temp_str = Console.ReadLine();

            if (int.TryParse(temp_str, out int temp))
            {
                if (temp < 0)
                {
                    Console.WriteLine("Donuyor");
                }
                else if (temp >= 0 && temp < 30) 
                {
                    Console.WriteLine("Normal");
                }
                else
                {
                    Console.WriteLine("Sıcak");
                }
            }


            // Number between 1-7
            Console.Write("1 ile 7 arasında sayı girin: ");
            string one_seven_str = Console.ReadLine();

            int one_seven = Convert.ToInt32(one_seven_str);

            switch (one_seven)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;

                case 2:
                    Console.WriteLine("Salı");
                    break;

                case 3:
                    Console.WriteLine("Salı");
                    break;

                case 4:
                    Console.WriteLine("Çarşamba");
                    break;

                case 5:
                    Console.WriteLine("Perşembe");
                    break;

                case 6:
                    Console.WriteLine("Cuma");
                    break;

                case 7:
                    Console.WriteLine("Pazar");
                    break;

                default:
                    Console.WriteLine("Geçerli bir sayı giriniz.");
                    break;
            }
            

            // Score determination
            Console.Write("0 ile 100 arasında notunuzu girin: ");
            string score_str = Console.ReadLine();

            if (int.TryParse(score_str, out int score) && score >= 0 && score <= 100)
            {
                if (score <= 60)
                {
                    Console.WriteLine("Başarısız");
                }
                else if (score >= 81)
                {
                    Console.WriteLine("Başarılı");
                }
                else
                {
                    Console.WriteLine("Orta");
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir not giriniz.");
            }


            // Months of a year
            Console.Write("Bir ay numarası (1-12) girin: ");
            string month_str = Console.ReadLine();

            if (int.TryParse(month_str, out int month))
            {
                if (month == 2)
                {
                    Console.WriteLine("Bu ayda 28 gün vardır.");
                }
                // Exception for July because it take 31 days
                else if (month % 2 == 0 || month == 7)
                {
                    Console.WriteLine("Bu ayda 31 gün vardır.");
                }
                else
                {
                    Console.WriteLine("Bu ayda 30 gün vardır.");
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir ay giriniz.");
            }


            // Password Check
            Console.Write("Şifreyi girin: ");
            string password_str = Console.ReadLine();

            switch (password_str) 
            {
                case "12345":
                    Console.WriteLine("Giriş Başarılı");
                    break;
                default:
                    Console.WriteLine("Giriş Başarısız");
                    break;
            }


            // Calculator
            Console.Write("Birinci sayıyı girin: ");
            string firstNumStr = Console.ReadLine();
            if (!decimal.TryParse(firstNumStr, out decimal first_num))
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
                return;
            }

            Console.Write("İkinci sayıyı girin: ");
            string secondNumStr = Console.ReadLine();
            if (!decimal.TryParse(secondNumStr, out decimal second_num))
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
                return;
            }

            Console.Write("Yapmak istediğiniz işlem (+, -, *, /): ");
            string operation_str = Console.ReadLine();

            switch (operation_str)
            {
                case "+":
                    Console.WriteLine($"Sonuç: {first_num + second_num}");
                    break;
                case "-":
                    Console.WriteLine($"Sonuç: {first_num - second_num}");
                    break;
                case "*":
                    Console.WriteLine($"Sonuç: {first_num * second_num}");
                    break;
                case "/":
                    if (second_num == 0)
                    {
                        Console.WriteLine("Hata: Bir sayıyı 0'a bölemezsiniz.");
                    }
                    else
                    {
                        Console.WriteLine($"Sonuç: {first_num / second_num}");
                    }
                    break;
                default:
                    Console.WriteLine("Yanlış işlem girdiniz.");
                    break;
            }
        }
    }
}