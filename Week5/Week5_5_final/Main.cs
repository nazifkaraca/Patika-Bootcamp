using System.Globalization;
using System.Xml.Linq;

namespace Week5_5_final;

class Program
{
    static void Main(string[] args)
    {
        //1- Konsol ekranından kullanıcıya araba üretmek isteyip istemediğini soralım.Üretmek istiyorsa e, istemiyorsa h harfi ile yanıt versin. Büyük - Küçük harf duyarlılığını ortadan kaldıralım.Geçersiz bir cevap verirse, bu cevabın geçersiz olduğunu söyleyerek aynı soruyu tekrar yöneltelim.

        List<Araba> arabalar = new();
        ReadWriteClass rd = new();
        bool isContinue = true;

        do
        {
            try
            {
                Araba araba = new Araba
                {
                    Name = Console.ReadLine(),
                    Model = Console.ReadLine(),
                    Price = Convert.ToDecimal(
                        rd.ReadWrite("Fiyat: ", ConsoleColor.Blue)
                        ),
                    Door = Convert.ToInt32(Console.ReadLine())
                };

                arabalar.Add(araba);
                foreach (var car in arabalar)
                {
                    Console.WriteLine(car);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                isContinue = false;
            }

        } while (isContinue);

        Console.ReadKey();
//2- Kullanıcının cevabı hayır programı sonlandıralım, evet ise bir araba nesnesi üretip özelliklerini konsol ekranından kullanıcıya girdirelim.
    }
}

class Araba
{
    public DateTime ProdDate => DateTime.Now;
    private string _name;
    private string _model;
    private decimal _price;
    private int _door;

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
                throw new Exception("Geçersiz bir kapı sayısı girildi!");
            }
        }
    }

    public decimal Price
    {
        get { return _price; }
        set 
        { 
            if (value < 0)
            {
                throw new Exception("Lütfen pozitif bir sayı girin!");
            }
            else
            {
                _price = value;
            }
        }
    }

    public string Model
    {
        get { return _model;; }
        set 
        { 
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Araba modeli boş olamaz!");
            }
            else
            {
                _model = value;
            }
        }
    }

    public string Name
    {
        get { return _name; }
        set 
        { 
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Araba ismi boş olamaz!");   
            }
            else
            {
                _name = value;
            }
        }
    }

    public Araba() { }

    public Araba(string name, string model, int door, decimal price)
    {
        _name = name;
        _model = model;
        _door = door;
        _price = price;
    }

    public override string ToString()
    {
        return $"Araba İsmi: {Name}, Modeli: {Model}, Kapı Sayısı: {Door}, Fiyat: {Price:c3}";
    }

}

class ReadWriteClass
{
    public string ReadWrite(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(text);
        Console.ResetColor();
        string? input = Console.ReadLine();

        return input;
    }
}
//4- Kapı Sayısı için sayısal olmayan bir değer atanılmaya çalışılırsa programın exception fırlatmasını engelleyelim, uyarı mesajı verelim ve kullanıcıyı yeniden o satıra yönlendirelim. (goto komutunu araştırınız.)

//5- Oluşturulan araba nesnesini arabalar isimli bir listeye atayınız.

//6- Kullanıcıya başka araba oluşturmak isteyip istemediğini sorunuz, evet ise program akışında 2. aşamaya geri dönünüz ve yeni bir araba üretip listeye ekleyiniz. Cevap hayır ise arabalar listesinin bütün elemanlarının Seri numaralarını ve markalarını yazdırınız