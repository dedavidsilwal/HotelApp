using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HotelApp.Data
{
    /* This is used if database provider does't define
     * IHotelAppDbSchemaMigrator implementation.
     */
    public class NullHotelAppDbSchemaMigrator : IHotelAppDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}