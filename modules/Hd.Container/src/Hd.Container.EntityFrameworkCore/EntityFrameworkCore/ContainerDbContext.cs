using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Hd.Container.EntityFrameworkCore
{
    [ConnectionStringName(ContainerDbProperties.ConnectionStringName)]
    public class ContainerDbContext : AbpDbContext<ContainerDbContext>, IContainerDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public ContainerDbContext(DbContextOptions<ContainerDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureContainer();
        }
    }
}