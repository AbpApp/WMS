using Hd.Container.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Hd.Container
{
    public abstract class ContainerController : AbpController
    {
        protected ContainerController()
        {
            LocalizationResource = typeof(ContainerResource);
        }
    }
}
