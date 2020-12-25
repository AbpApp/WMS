using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Hd.Container.EntityFrameworkCore
{
    public class ContainerModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ContainerModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}