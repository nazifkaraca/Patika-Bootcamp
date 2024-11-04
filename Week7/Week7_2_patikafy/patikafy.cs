using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_2_patikafy
{
    public class Patikafy
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int ReleaseDate { get; set; }
        public decimal Sales { get; set; }

        public Patikafy(string name, string genre, int releaseDate, decimal sales)
        {
            Name = name;
            Genre = genre;
            ReleaseDate = releaseDate;
            Sales = sales;
        }

        public override string ToString()
        {
            return $"{Name, -13} | {Genre, -4} | {ReleaseDate, -4} | {Sales} Milyon";
        }
    }
}
