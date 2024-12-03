namespace Week11_3_GalacticTourAgency.Models
{
    public class GalacticCoordinate
    {
        public double X { get; set; }
        public double Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
}
