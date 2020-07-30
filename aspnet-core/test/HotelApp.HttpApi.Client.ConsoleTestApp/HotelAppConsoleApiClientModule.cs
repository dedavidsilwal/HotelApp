using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace HotelApp.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(HotelAppHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class HotelAppConsoleApiClientModule : AbpModule
    {
        
    }
}
