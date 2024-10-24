using System.Data.Common;
using System.Net.WebSockets;

namespace Week5_4_exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bir sayı giriniz: ");
                double input = double.Parse(Console.ReadLine());

                Console.WriteLine($"{input} karesi: {Math.Pow(input, 2)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Beklenmedik bir hata oluştu: {e}");
            }
            finally
            {
                Console.WriteLine("Program çalıştırıldı.");
            }
        }
    }
}
