using HotelApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace HotelApp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(HotelAppEntityFrameworkCoreDbMigrationsModule),
        typeof(HotelAppApplicationContractsModule)
        )]
    public class HotelAppDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
