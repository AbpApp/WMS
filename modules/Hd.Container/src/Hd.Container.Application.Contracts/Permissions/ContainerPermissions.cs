using Volo.Abp.Reflection;

namespace Hd.Container.Permissions
{
    public class ContainerPermissions
    {
        public const string GroupName = "Container";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ContainerPermissions));
        }
    }
}