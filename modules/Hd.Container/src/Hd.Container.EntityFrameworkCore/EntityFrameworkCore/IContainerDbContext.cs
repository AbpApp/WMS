using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Hd.Container.EntityFrameworkCore
{
    [ConnectionStringName(ContainerDbProperties.ConnectionStringName)]
    public interface IContainerDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}