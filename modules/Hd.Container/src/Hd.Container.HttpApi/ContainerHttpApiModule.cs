using Localization.Resources.AbpUi;
using Hd.Container.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Hd.Container
{
    [DependsOn(
        typeof(ContainerApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class ContainerHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(ContainerHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ContainerResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
