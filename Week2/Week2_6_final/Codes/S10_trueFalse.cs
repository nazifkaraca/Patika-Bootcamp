namespace S10
{
	public class S10_Class
	{
		public string trueFalse()
		{
            Console.Write("True mu False mu?: ");
			string response = Console.ReadLine().ToLower();

            return response == "true" ? "Bence de doğru." : "Bence de yanlış.";
        }
	}
}
