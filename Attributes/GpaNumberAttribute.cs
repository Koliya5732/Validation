using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Validation.Attributes
{
    public class GpaNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(
            object? value,
            ValidationContext validationContext)
        {
            if (value == null)
                return ValidationResult.Success;

            string text = value.ToString()!;

            if (!double.TryParse(
                text,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out _))
            {
                return new ValidationResult(
                    "Середній бал повинен містити тільки цифри");
            }

            return ValidationResult.Success;
        }
    }
}