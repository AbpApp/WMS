using Hd.Container.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Hd.Container.Permissions
{
    public class ContainerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ContainerPermissions.GroupName, L("Permission:Container"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ContainerResource>(name);
        }
    }
}