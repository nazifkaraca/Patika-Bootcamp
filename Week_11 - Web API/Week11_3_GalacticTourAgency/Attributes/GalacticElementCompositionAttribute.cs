using System.ComponentModel.DataAnnotations;

namespace Week11_3_GalacticTourAgency.Attributes
{
    public class GalacticElementCompositionAttribute : ValidationAttribute
    {
        private readonly string[] _validElements = new[]
        {
            "Hidrojen", "Karbon", "Oksijen", "Silikon", "Helyum", "Neon"
        };

        public int MinElements { get; }

        public int MaxElements { get; }


        public GalacticElementCompositionAttribute(int minElements = 1, int maxElements = 5)
        {
            MinElements = minElements;
            MaxElements = maxElements;
        }


        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string composition)
            {
                var elements = composition.Split(',').Select(s => s.Trim()).ToList();

                if (elements.Count < MinElements || elements.Count > MaxElements)
                {
                    return new ValidationResult($"Bileşen içerik sayısı {MinElements} ile {MaxElements} arasında olmalıdır.");
                }

                var invalidElements = elements.Except(_validElements, StringComparer.OrdinalIgnoreCase).ToList();

                if (invalidElements.Any())
                {
                    return new ValidationResult($"Geçersiz eleman saptandı: {string.Join(",", invalidElements)}. Geçerli elementler: {string.Join(",", _validElements)}");
                }

                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Geçersiz değer. Virgüller ile ayrılmış halde girmelisiniz");
            }
        }
    }
}
