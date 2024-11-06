namespace Week_7_3_patikaflix
{
    public class Patikaflix
    {
        public string Name { get; set; }
        public string ProductionDate { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public string Director { get; set; }
        public string Platform { get; set; }

        public Patikaflix() { }

        public Patikaflix(string name, string productionDate, string genre, string releaseDate, string director, string platform)
        {
            Name = name;
            ProductionDate = productionDate;
            Genre = genre;
            ReleaseDate = releaseDate;
            Director = director;
            Platform = platform;
        }

        // Override ToString method for better output
        public override string ToString()
        {
            return $"Adı {Name}, Yapım Yılı {ProductionDate}, Türü {Genre}, " +
                $"Yayınlanma Tarihi {ReleaseDate}, Yönetmeni {Director}, Platformu {Platform} olan dizi eklendi.";
        }

        // A method for creating a show 
        public static Patikaflix CreateShow(List<string> titles)
        {
            Patikaflix show = new();

            foreach (string title in titles)
            {
                Console.Write($"{title}: ");
                string input = Console.ReadLine();

                switch (title)
                {
                    case "Name": show.Name = input; break;
                    case "ProductionDate": show.ProductionDate = input; break;
                    case "Genre": show.Genre = input; break;
                    case "ReleaseDate": show.ReleaseDate = input; break;
                    case "Director": show.Director = input; break;
                    case "Platform": show.Platform = input; break;
                }
            }
            return show;
        }
    }

    // PatikaflixLite class defined separately for name, genre and director
    public class PatikaflixComedy
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        // A method for creating comedy movies from a list
        public static List<PatikaflixComedy> ComedySeries(List<Patikaflix> tvshows)
        {
            List<PatikaflixComedy> comedySeries = tvshows
                .Where(show => show.Genre.ToLower() == "komedi")
                .Select(show => new PatikaflixComedy
                {
                    Name = show.Name,
                    Genre = show.Genre,
                    Director = show.Director
                })
                .ToList();

            return comedySeries;
        }
    }
}
