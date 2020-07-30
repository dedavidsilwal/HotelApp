using HotelApp.Hotels;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace HotelApp.EntityFrameworkCore
{
    public static class HotelAppDbContextModelCreatingExtensions
    {
        public static void ConfigureHotelApp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Hotel>(b => {
                b.ToTable(HotelAppConsts.DbTablePrefix + "Hotels", HotelAppConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

                b.Property(x => x.Name).IsRequired().HasMaxLength(50);
                b.Property(x => x.Location).IsRequired().HasMaxLength(50);

                //...
            });
        }
    }
}