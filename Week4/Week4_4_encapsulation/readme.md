# Araba Sýnýfý - Encapsulation Örneði

Bu projede, `Araba` sýnýfý oluþturularak kapsülleme (encapsulation) prensiplerine uygun bir örnek geliþtirilecektir. Amaç, `Kapý Sayýsý` özelliði için kapsülleme iþlemi yaparak, sadece geçerli deðerlerin (2 veya 4) atanmasýna izin vermektir.

## Özellikler

Araba sýnýfýnýn aþaðýdaki özelliklere sahip olmasý gerekmektedir:

- **Marka**: Arabanýn markasý (string).
- **Model**: Arabanýn modeli (string).
- **Renk**: Arabanýn rengi (string).
- **Kapý Sayýsý**: Arabanýn kapý sayýsý (int).

## Kapsülleme Þartý

- Eðer bir `Araba` nesnesine **2** veya **4** dýþýnda bir kapý sayýsý atanmak istenirse, konsol ekranýnda bir uyarý mesajý verilmelidir:  
  **"Kapý sayýsý 2 veya 4 olmalýdýr!"**
- Geçersiz bir kapý sayýsý atanýrsa, `Kapý Sayýsý` deðeri **-1** olarak atanmalýdýr.

## Kullaným

### Araba Sýnýfý Örneði

Aþaðýdaki C# kodu, `Araba` sýnýfýnýn nasýl kullanýldýðýný gösterir.

```csharp
using System;

namespace Araba
{
    public class Car
    {
        private string _brand;
        private string _model;
        private string _color;
        private int _door;

        // Constructor to initialize brand, model, and color
        public Car(string Brand, string Model, string Color)
        {
            _brand = Brand;
            _model = Model;
            _color = Color;
        }

        // Property to encapsulate door and validate the value
        public int Door
        {
            get { return _door; }
            set
            {
                if (value == 2 || value == 4) // Check the incoming value
                {
                    _door = value;
                }
                else
                {
                    Console.WriteLine("Kapý sayýsý 2 veya 4 olmalýdýr!");
                    _door = -1; // Set to -1 if invalid
                }
            }
        }

        // Method to display car information
        public void DisplayCar()
        {
            Console.WriteLine($"Marka: {_brand}\n" +
                              $"Model: {_model}\n" +
                              $"Renk: {_color}\n" +
                              $"Kapý Sayýsý: {_door}");
        }
    }
}
