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

            var hotelsPermission = myGroup.AddPermission(HotelAppPermissions.Hotels.Default, L("Permission:Hotels"));
            hotelsPermission.AddChild(HotelAppPermissions.Hotels.Create, L("Permission:Hotels.Create"));
            hotelsPermission.AddChild(HotelAppPermissions.Hotels.Edit, L("Permission:Hotels.Edit"));
            hotelsPermission.AddChild(HotelAppPermissions.Hotels.Delete, L("Permission:Hotels.Delete"));


       }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<HotelAppResource>(name);
        }
    }
}
