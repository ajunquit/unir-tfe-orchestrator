using Microsoft.Extensions.DependencyInjection;
using UNIR.TFE.Polyrepo.Addition.Module.Application;
using UNIR.TFE.Polyrepo.Division.Module.Application;
using UNIR.TFE.Polyrepo.Multiplication.Module.Application;
using UNIR.TFE.Polyrepo.Subtraction.Module.Application;

namespace UNIR.TFE.Polyrepo.Orchestrator.Module.Test
{
    public class ConfigureServicesTests
    {
        [Fact]
        public void AddOrchestratorModule_RegistersAppServicesWithScopedLifetime()
        {
            // Arrange
            var services = new ServiceCollection();

            // Act
            services.AddOrchestratorModule();

            // Assert
            AssertServiceRegisteredAsScoped<IAdditionAppService, AdditionAppService>(services);
            AssertServiceRegisteredAsScoped<ISubtractionAppService, SubtractionAppService>(services);
            AssertServiceRegisteredAsScoped<IMultiplicationAppService, MultiplicationAppService>(services);
            AssertServiceRegisteredAsScoped<IDivisionAppService, DivisionAppService>(services);
        }

        private static void AssertServiceRegisteredAsScoped<TService, TImpl>(IServiceCollection services)
        {
            var descriptor = Assert.Single(services, d => d.ServiceType == typeof(TService));
            Assert.Equal(ServiceLifetime.Scoped, descriptor.Lifetime);
            Assert.Equal(typeof(TImpl), descriptor.ImplementationType);
        }
    }
}