using Abstraction;

namespace Week4_7_abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Create an instance from a constructor
            Developer kisi1 = new("Kürşat", "Özgen");
            kisi1.Gorev();

            // Create an instance from a constructor
            ProjectManager kisi2 = new("Burak", "Oral");
            kisi2.Gorev();
        }
    }
}
