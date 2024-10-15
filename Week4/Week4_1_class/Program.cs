using PersonNamespace;

namespace Week3_1_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ogrenci = new Person
            {
                Name = "Nazif",
                Surname = "Karaca",
                Occupation = "Öğrenci",
                BirthDate = new DateTime(1998, 07, 11)
            };

            ogrenci.DisplayPerson();

            Person ogretmen = new Person
            {
                Name = "Memati",
                Surname = "Baş",
                Occupation = "Öğretmen",
                BirthDate = new DateTime(1974, 05, 27),
            };

            ogretmen.DisplayPerson();

            Console.ReadKey();
        }
    }
}
