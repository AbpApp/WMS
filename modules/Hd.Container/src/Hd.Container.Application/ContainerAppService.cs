using Hd.Container.Localization;
using Volo.Abp.Application.Services;

namespace Hd.Container
{
    public abstract class ContainerAppService : ApplicationService
    {
        protected ContainerAppService()
        {
            LocalizationResource = typeof(ContainerResource);
            ObjectMapperContext = typeof(ContainerApplicationModule);
        }
    }
}
