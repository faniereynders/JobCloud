using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(JobCloud.Api.Startup))]

namespace JobCloud.Api
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {

            builder.Services.AddSingleton<ICustomerRepository,CustomerRepositoryMock>();

        }
    }
}