using Microsoft.AspNetCore.Mvc.ModelBinding;
using Week11_3_GalacticTourAgency.Models;

namespace Week11_3_GalacticTourAgency.ModelBinding
{
    public class GalacticCoordinateBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName).FirstValue;

            if (string.IsNullOrWhiteSpace(value))
            {
                return Task.CompletedTask;
            }

            // Coordinate = 12.45,21.54

            var parts = value.Split(',');

            if (parts.Length != 2 || !double.TryParse(parts[0], out double x) || !double.TryParse(parts[1], out double y))
            {
                bindingContext.ModelState.AddModelError(bindingContext.ModelName, "Geçersiz koordinat bilgisi. 'X.XX,Y.YY' formatını kullanmalısınız.");

                return Task.CompletedTask;
            }

            var result = new GalacticCoordinate
            {
                X = x,
                Y = y
            };

            bindingContext.Result = ModelBindingResult.Success(result);

            return Task.CompletedTask;
        }
    }
}
