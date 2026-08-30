using Microsoft.AspNetCore.Mvc.ModelBinding;
using Validation.Models;

namespace Validation.Services
{
    public interface IValidationService
    {
        void Validate(Student student, ModelStateDictionary modelState);
    }
}