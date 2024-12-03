namespace Week11_3_GalacticTourAgency.Models
{
    public class GalacticTour
    {
        public int Id { get; set; }
        public string PlanetName { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}
