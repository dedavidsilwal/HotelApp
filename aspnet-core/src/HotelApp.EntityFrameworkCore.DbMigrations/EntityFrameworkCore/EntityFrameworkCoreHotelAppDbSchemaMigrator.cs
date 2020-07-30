using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HotelApp.Data;
using Volo.Abp.DependencyInjection;

namespace HotelApp.EntityFrameworkCore
{
    public class EntityFrameworkCoreHotelAppDbSchemaMigrator
        : IHotelAppDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreHotelAppDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the HotelAppMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<HotelAppMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}