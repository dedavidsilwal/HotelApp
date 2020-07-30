using Volo.Abp.Modularity;

namespace HotelApp
{
    [DependsOn(
        typeof(HotelAppApplicationModule),
        typeof(HotelAppDomainTestModule)
        )]
    public class HotelAppApplicationTestModule : AbpModule
    {

    }
}