using Volo.Abp.Settings;

namespace HotelApp.Settings
{
    public class HotelAppSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(HotelAppSettings.MySetting1));
        }
    }
}
