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

                //b.OwnsOne(h => h.Location, l => {
                //    l.ToTable("HotelLocation");                   
                //});

                //b.OwnsOne(h => h.Address, a => a.ToTable("HotelAddress"));


                //b.OwnsOne(h => h.Address, a => {
                //    a.WithOwner().HasForeignKey(p=>p.HotelId);
                //    a.Property<int>("Id");
                //    a.HasKey("Id");

                //});



                //b.OwnsMany(h => h.ContactPeoples, a => {
                //    a.WithOwner().HasForeignKey(p => p.HotelId);
                //    a.Property(p => p.Id);
                //    a.HasKey(p => p.Id);
                //});

                //b.OwnsMany(h => h.Rooms, a => {
                //    a.WithOwner().HasForeignKey(p => p.HotelId);
                //    a.Property(p => p.Id);
                //    a.HasKey(p => p.Id);
                //});


                b.Property(h => h.CheckinTime).HasColumnType("time");
                b.Property(h => h.CheckoutTime).HasColumnType("time");


                b.HasMany(p => p.Rooms).WithOne(h => h.Hotel).OnDelete(DeleteBehavior.ClientSetNull);
                b.HasMany(p => p.ContactPeoples).WithOne(h => h.Hotel).OnDelete(DeleteBehavior.ClientSetNull);

            });


            builder.Entity<HotelType>(b => {

                b.ToTable(HotelAppConsts.DbTablePrefix + "HotelTypes", HotelAppConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

                b.Property(x => x.Name).IsRequired().HasMaxLength(50);
                b.Property(x => x.Description).IsRequired().HasMaxLength(120);

                b.HasOne(p => p.Hotel).WithOne(p => p.HotelType).HasForeignKey<Hotel>(p => p.HotelTypeId);


            });

            builder.Entity<Address>(b => {

                b.ToTable(HotelAppConsts.DbTablePrefix + "HotelAddresss", HotelAppConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<Location>(b => {

                b.ToTable(HotelAppConsts.DbTablePrefix + "HotelLocations", HotelAppConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });



            builder.Entity<ContactPerson>(b => {

                b.ToTable(HotelAppConsts.DbTablePrefix + "HotelContactPerson", HotelAppConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });

            builder.Entity<Room>(b => {

                b.ToTable(HotelAppConsts.DbTablePrefix + "HotelRoom", HotelAppConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });
            //builder.Entity<Room>().Property(p => p.Price).HasForeignKey("Money");

            //builder.Entity<Hotel>()
            //    .HasOne(p => p.HotelType)
            //    .WithOne(p => p.Hotel)
            //    .HasForeignKey<HotelType>(p => p.HotelId);


            //builder.Entity<HotelService>(b => {

            //    b.ToTable(HotelAppConsts.DbTablePrefix + "HotelServices", HotelAppConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props

            //    b.Property(x => x.Name).IsRequired().HasMaxLength(50);

            //});

            //builder.Entity<ServicePerHotel>().HasKey(sph => new { sph.HotelId, sph.ServiceId });

            //builder.Entity<RoomService>(b => {
            //    b.Property(x => x.Name).IsRequired().HasMaxLength(50);
            //});

            //builder.Entity<ServicePerRoom>().HasKey(sph => new { sph.RoomTypeId, sph.ServiceId });

        }
    }
}