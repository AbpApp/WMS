using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Hd.Container
{
    [DependsOn(
        typeof(ContainerApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ContainerHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Container";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ContainerApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
