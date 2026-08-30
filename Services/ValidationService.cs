using Microsoft.AspNetCore.Mvc.ModelBinding;
using Validation.Models;

namespace Validation.Services
{
    public class ValidationService : IValidationService
    {
        public void Validate(Student student, ModelStateDictionary modelState)
        {
            if (student.Surname == "admin")
                modelState.AddModelError(
                    "Surname",
                    "admin - заборонене прізвище");

            if (student.Name == student.Email)
                modelState.AddModelError(
                    "",
                    "ім’я та електронна адреса не повинні збігатися");
        }
    }
}