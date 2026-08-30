using Microsoft.Extensions.DependencyInjection;

namespace Validation.Services
{
    public static class ValidationExtensions
    {
        public static IServiceCollection AddMyValidation(
            this IServiceCollection services)
        {
            services.AddScoped<IValidationService, ValidationService>();

            return services;
        }
    }
}