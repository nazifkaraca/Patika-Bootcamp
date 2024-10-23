using System.Collections.Generic;
using System.Net.WebSockets;

namespace Week5_3_IMDB
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            List<List<object>> list = IMDB.GetInput();
            IMDB.ShowList(list);
            Console.ReadLine();
        }

        public class IMDB
        {
            private static string _name;
            private static double _score;
            private static readonly List<List<object>> list = new();

            public static string Name 
            {
                get {  return _name; }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        _name = value;
                    }
                    else
                    {
                        Console.WriteLine("Film adı boş olamaz!");
                    }
                }
            
            }

            public static double Score
            {
                get { return _score; }
                set
                {
                    if (value < 0 || value > 10)
                    {
                        Console.WriteLine("IMDB Puanı 0 ile 10 arasında bir değer almalıdır!");
                    }
                    else
                    {
                        _score = Math.Round(value, 2);
                    }
                }
            }

            public static List<List<object>> GetInput()
            {
                Console.Write("Film Adı: ");
                Name = Console.ReadLine();

                Console.Write("IMDB Puanı: ");
                Score = Convert.ToDouble(Console.ReadLine());

                list.Add([Name, Score]);

                return list;
            }

            public static void ShowList(List<List<object>> list)
            {
                foreach (var item in list)
                {
                    foreach (var item2 in item)
                    {
                        Console.Write(item2);
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}
