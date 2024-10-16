namespace LibraryApp
{
	public class Library
	{
		public string BookName { get; set; }
		public string AuthorName { get; set; }
		public string AuthorSurname { get; set; }
		public int PageCount { get; set; }
		public string PublishHouse { get; set; }
		public DateTime RegDate { get; set; }

		// Default constructor
		public Library()
		{
			// Set time to now
			RegDate = DateTime.Now;
        }

		// Constructor taking parameters
		public Library(string bookName, string authorName, int pageCount, string publishHouse) : this() // Go default constructor to set registration date
		{
			BookName = bookName;
			AuthorName = authorName;
			PageCount = pageCount;
			PublishHouse = publishHouse;

			// Show registration information
            PrivateDatabase();
		}

		// Present information public
		public void LibraryDatabase()
		{
            Console.WriteLine($"Kitap Adı: {BookName}\nYazar Adı: {AuthorName}\nYazar Soyadı: {AuthorSurname}\nSayfa Sayısı: {PageCount}\nYayınevi: {PublishHouse}\nKayıt Tarihi: {RegDate}");
		}

		// Present information private
		private void PrivateDatabase()
		{
			Console.WriteLine($"Kitap Adı: {BookName}\nYazar Adı: {AuthorName}\nSayfa Sayısı: {PageCount}\nYayınevi: {PublishHouse}\nKayıt Tarihi: {RegDate}");
        }
	}

}
