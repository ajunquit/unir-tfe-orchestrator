using Microsoft.Extensions.DependencyInjection;
using UNIR.TFE.Polyrepo.Addition.Module.Application;
using UNIR.TFE.Polyrepo.Division.Module.Application;
using UNIR.TFE.Polyrepo.Multiplication.Module.Application;
using UNIR.TFE.Polyrepo.Subtraction.Module.Application;

namespace UNIR.TFE.Polyrepo.Orchestrator.Module
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddOrchestratorModule(this IServiceCollection services)
        {
            services.AddScoped<IAdditionAppService, AdditionAppService>();
            services.AddScoped<ISubtractionAppService, SubtractionAppService>();
            services.AddScoped<IMultiplicationAppService, MultiplicationAppService>();
            services.AddScoped<IDivisionAppService, DivisionAppService>();
            return services;
        }

    }
}
