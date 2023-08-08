using TestMDC.Endpoints.Exercise1;
using TestMDC.Endpoints.Exercise2;
using TestMDC.Endpoints.Exercise3;
using TestMDC.Endpoints.Exercise4;
using TestMDC.Endpoints.Exercise5;
using TestMDC.Endpoints.Exercise6;
using TestMDC.Endpoints.Exercise7;
using TestMDC.Endpoints.Exercise8;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MySettingsServices
    {
        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {

            services.AddScoped<ISimpleCalculatorEndpoints, SimpleCalculatorEndpoints>();
            services.AddScoped<IPrimeNumbersEndpoint, PrimeNumbersEndpoint>();
            services.AddScoped<IFactorialEndpoint, FactorialEndpoint>();
            services.AddScoped<IPalindromeEndpoint, PalindromeEndpoint>();
            services.AddScoped<ITableEndpoint, TableEndpoint>();
            services.AddScoped<IVowelCounter, VowelCounter>();
            services.AddScoped<IGradeAverage, GradeAverage>();
            services.AddScoped<IInterestCalculation, InterestCalculation>();

            return services;
        }
    }
}

