using Hd.Container.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Hd.Container
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(ContainerEntityFrameworkCoreTestModule)
        )]
    public class ContainerDomainTestModule : AbpModule
    {
        
    }
}
