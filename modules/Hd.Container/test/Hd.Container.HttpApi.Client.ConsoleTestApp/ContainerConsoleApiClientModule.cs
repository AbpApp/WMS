using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Hd.Container
{
    [DependsOn(
        typeof(ContainerHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ContainerConsoleApiClientModule : AbpModule
    {
        
    }
}
