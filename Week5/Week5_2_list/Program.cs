namespace Week5_2_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            while (true)
            {
                Console.Write("Ziyaretçi ekle (bitirmek için 0 yazın): ");
                list.Add(Console.ReadLine());

                if (list[list.Count - 1] == "0")
                {
                    list.Remove("0");
                    Console.WriteLine("Programdan çıkılıyor.");
                    break;
                }
            }

            Console.WriteLine("\n== Davetliler ==");
            for (int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine($"{i+1} - {list[i]}");
            }
        }
    }
}
