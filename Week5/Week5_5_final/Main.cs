using System;
using System.Collections.Generic;

namespace Week5_5_final
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Araba> arabalar = new List<Araba>();
            bool isContinue = true;

            do
            {
                // Gather input and create a new Araba
                var araba = CreateAraba();
                arabalar.Add(araba);

                Console.Write("Araba üretmek istiyor musunuz (y/n): ");
                isContinue = Console.ReadLine().ToLower() == "y";

            } while (isContinue);

            // Display all cars in the list
            Console.WriteLine("\nÜretilen arabalar:");
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

            Console.ReadLine();  // Wait for input before closing the console
        }

        // Method to gather input and create an Araba
        static Araba CreateAraba()
        {
            Console.Write("Arabanın İsmi: ");
            string name = Console.ReadLine();

            Console.Write("Arabanın Modeli: ");
            string model = Console.ReadLine();

            int serialNumber;
            do
            {
                Console.Write("Arabanın Seri Numarası: ");
            } while (!int.TryParse(Console.ReadLine(), out serialNumber));

            decimal price;
            do
            {
                Console.Write("Arabanın Fiyatı: ");
            } while (!decimal.TryParse(Console.ReadLine(), out price));

            int door;
            do
            {
                Console.Write("Arabanın Kapı Sayısı (2 veya 4 olabilir): ");
            } while (!int.TryParse(Console.ReadLine(), out door) || (door != 2 && door != 4));

            return new Araba(name, model, serialNumber, price, door);
        }
    }

    class Araba
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int SerialNumber { get; set; }
        public decimal Price { get; set; }
        public int Door { get; set; }
        public DateTime ProdDate { get; }

        public Araba(string name, string model, int serialNum, decimal price, int door)
        {
            this.Name = name;
            this.Model = model;
            this.SerialNumber = serialNum;
            this.Price = price;
            this.Door = door;
            this.ProdDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Seri No: {SerialNumber}, Marka: {Name}, Model: {Model}, Fiyat: {Price}, Kapı: {Door}, Üretim Tarihi: {ProdDate}";
        }
    }
}
