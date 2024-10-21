using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_8_OOProject
{
    public abstract class BaseMakine
    {
        // Determine shared properties
        public DateTime ProductionDate { get; }
        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        // Create a constructor
        protected BaseMakine(int serialNumber, string name, string description, string operatingSystem)
        {
            ProductionDate = DateTime.Now;
            SerialNumber = serialNumber;
            Name = name;
            Description = description; 
            OperatingSystem = operatingSystem;
        }

        // Create an abstract method
        public abstract void UrunAdiGetir();

        // Create an virtual method for overriding
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Seri Numarası => {SerialNumber}\n" +
                $"Üretim Tarihi => {ProductionDate}\n" +
                $"Ürünün İsmi => {Name}\n" +
                $"Açıklama => {Description}\n" +
                $"İşletim Sistemi => {OperatingSystem}");
        }
    }

    // Phone class
    public class Telefon : BaseMakine
    {
        public bool IsLicenced { get; set; } 

        // Create a constructor inherited from base/parent class (BaseMakine)
        public Telefon(int serialNumber, string name, string description, string operatingSystem, bool isLicenced) : base(serialNumber, name, description, operatingSystem) 
        {
            IsLicenced = isLicenced;
        }

        // Override base method
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Name}");
        }

        // Override base method
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"TR Lisans Durumu => {IsLicenced}");
        }
    }

    // Computer class
    public class Bilgisayar : BaseMakine
    {
        private int _usbPort;
        protected bool Bluetooth {  get; set; }

        // Arrange getter and setter for UsbPort
        protected int UsbPort
        {
            get
            {
                return _usbPort;
            }
            set
            {
                // Check whether user entered an int other than 2 or 4
                if (value == 2 || value == 4)
                {   
                    _usbPort = value;
                }
                else
                {
                    // Warn user to enter 2 or 4 as a value
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("USB giriş sayısı 2 veya 4 değerlerini alabilir!");
                    Console.ResetColor();
                    _usbPort = -1;
                }
            } 
        }

        // Create a constructor from the parent class
        public Bilgisayar(int serialNumber, string name, string description, string operatingSystem, int usbport, bool bluetooth) : base(serialNumber, name, description, operatingSystem) 
        {
            UsbPort = usbport;
            Bluetooth = bluetooth;
        }

        // Override the base method
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınız adı ---> {Name}");
        }

        // Override the base method
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı => {UsbPort}\n" +
                $"Bluetooth => {Bluetooth}");
        }
    }
}
