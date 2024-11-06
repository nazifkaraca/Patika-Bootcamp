namespace Week7_4_linq_join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Authors> authors = new()
            {
                new Authors(1, "İhsan Oktay Anar"),
                new Authors(2, "Sabahattin Ali"),
                new Authors(3, "Montaigne"),
                new Authors(4, "Ayn Rand")
            };

            List<Books> books = new()
            {
                new Books(1, "Amat", 1),
                new Books(2, "Atlas Silkindi", 4),
                new Books(3, "Hayatın Kaynağı", 4),
                new Books(4, "Kürk Mantolu Madonna", 2),
                new Books(5, "Denemeler", 3),
                new Books(6, "İçimizdeki Şeytan", 2)
            };

            var booksNauthors = from author in authors
                                join book in books on author.AuthorId equals book.AuthorId
                                select new
                                {
                                    AuthorName = author.Name,
                                    BookTitle = book.Title
                                };

            Console.WriteLine($"{"Yazar",-20} | {"Kitap",-15}");
            foreach (var book in booksNauthors) Console.WriteLine($"{book.AuthorName,-20} | {book.BookTitle,-15}");

            // İkinci Yol - Gruplayarak

            var booksNauthors2 = authors.GroupJoin(books,
                                                 author => author.AuthorId,
                                                 book => book.AuthorId,
                                                 (authors, books) => new
                                                 {
                                                     AuthorName = authors.Name,
                                                     BookName = books,
                                                 });   

            foreach (var author in booksNauthors2)
            {
                Console.WriteLine();
                Console.WriteLine($"{author.AuthorName}:");
                Console.WriteLine("-------------------");

                foreach (var book in author.BookName)
                {
                    Console.WriteLine($"Kitap: {book.Title}");
                }
            }

            Console.Read();

        }
    }
}
