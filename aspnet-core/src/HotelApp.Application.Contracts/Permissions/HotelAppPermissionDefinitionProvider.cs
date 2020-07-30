using HotelApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HotelApp.Permissions
{
    public class HotelAppPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(HotelAppPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(HotelAppPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<HotelAppResource>(name);
        }
    }
}
