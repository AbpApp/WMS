using Volo.Abp.Modularity;

namespace Hd.Container
{
    [DependsOn(
        typeof(ContainerApplicationModule),
        typeof(ContainerDomainTestModule)
        )]
    public class ContainerApplicationTestModule : AbpModule
    {

    }
}
