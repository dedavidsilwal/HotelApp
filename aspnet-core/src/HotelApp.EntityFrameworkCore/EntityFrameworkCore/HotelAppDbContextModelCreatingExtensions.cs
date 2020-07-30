using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace HotelApp.EntityFrameworkCore
{
    public static class HotelAppDbContextModelCreatingExtensions
    {
        public static void ConfigureHotelApp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(HotelAppConsts.DbTablePrefix + "YourEntities", HotelAppConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}