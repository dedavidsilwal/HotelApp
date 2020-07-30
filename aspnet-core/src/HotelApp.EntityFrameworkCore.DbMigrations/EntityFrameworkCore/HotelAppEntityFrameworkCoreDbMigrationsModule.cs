using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace HotelApp.EntityFrameworkCore
{
    [DependsOn(
        typeof(HotelAppEntityFrameworkCoreModule)
        )]
    public class HotelAppEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<HotelAppMigrationsDbContext>();
        }
    }
}
