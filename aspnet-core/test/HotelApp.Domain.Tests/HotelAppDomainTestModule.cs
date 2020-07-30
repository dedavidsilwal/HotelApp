using HotelApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace HotelApp
{
    [DependsOn(
        typeof(HotelAppEntityFrameworkCoreTestModule)
        )]
    public class HotelAppDomainTestModule : AbpModule
    {

    }
}