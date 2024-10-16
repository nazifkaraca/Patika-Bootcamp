using System.Runtime.CompilerServices;

namespace Araba
{
	public class Car
	{
		private string _brand;
		private string _model;
		private string _color;
		private int _door;

		public Car(string Brand, string Model, string Color)
		{
			_brand = Brand;
			_model = Model;
			_color = Color;
		}

		public int Door
		{
			get { return _door; }
			set
			{
				if (value == 2 || value == 4)
				{
					_door = value;
				}
				else
				{
                    Console.WriteLine("Kapı sayısı 2 veya 4 olmalıdır!");
                    _door = -1;
				}
			}
		}

		public void DisplayCar()
		{
			Console.WriteLine($"Marka: {_brand}\n" +
							  $"Model: {_model}\n" +
							  $"Renk: {_color}\n" +
							  $"Kapı Sayısı: {_door}");
		}
	}
}
