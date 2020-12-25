using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Hd.Container
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(ContainerDomainSharedModule)
    )]
    public class ContainerDomainModule : AbpModule
    {

    }
}
