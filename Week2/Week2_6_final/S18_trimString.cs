namespace S18
{
    public class S18_Class
    {
        public void StringTrim()
        {
            {
                string s = "    Selamlar   ";
                Console.WriteLine($"Normal hali: \"{s}\"");
                Console.WriteLine("Boşlukları silinmiş hali: " + s.Trim());
            }
        }
    }
}
