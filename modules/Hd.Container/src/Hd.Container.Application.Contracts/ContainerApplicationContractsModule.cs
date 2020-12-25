using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Hd.Container
{
    [DependsOn(
        typeof(ContainerDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class ContainerApplicationContractsModule : AbpModule
    {

    }
}
