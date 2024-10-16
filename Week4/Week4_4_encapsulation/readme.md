# Araba S�n�f� - Encapsulation �rne�i

Bu projede, `Araba` s�n�f� olu�turularak kaps�lleme (encapsulation) prensiplerine uygun bir �rnek geli�tirilecektir. Ama�, `Kap� Say�s�` �zelli�i i�in kaps�lleme i�lemi yaparak, sadece ge�erli de�erlerin (2 veya 4) atanmas�na izin vermektir.

## �zellikler

Araba s�n�f�n�n a�a��daki �zelliklere sahip olmas� gerekmektedir:

- **Marka**: Araban�n markas� (string).
- **Model**: Araban�n modeli (string).
- **Renk**: Araban�n rengi (string).
- **Kap� Say�s�**: Araban�n kap� say�s� (int).

## Kaps�lleme �art�

- E�er bir `Araba` nesnesine **2** veya **4** d���nda bir kap� say�s� atanmak istenirse, konsol ekran�nda bir uyar� mesaj� verilmelidir:  
  **"Kap� say�s� 2 veya 4 olmal�d�r!"**
- Ge�ersiz bir kap� say�s� atan�rsa, `Kap� Say�s�` de�eri **-1** olarak atanmal�d�r.

## Kullan�m

### Araba S�n�f� �rne�i

A�a��daki C# kodu, `Araba` s�n�f�n�n nas�l kullan�ld���n� g�sterir.

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
                    Console.WriteLine("Kap� say�s� 2 veya 4 olmal�d�r!");
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
                              $"Kap� Say�s�: {_door}");
        }
    }
}
