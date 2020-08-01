using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace HotelApp.Hotels
{
    public class HotelAppDataSeederContributor : IDataSeedContributor, ITransientDependency

    {
        private readonly IRepository<Hotel, Guid> _hotelRepository;
        private readonly IRepository<HotelType, Guid> _hotelTypeRepository;
        private readonly IGuidGenerator _guidGenerator;

        public HotelAppDataSeederContributor(
            IRepository<Hotel, Guid> hotelRepository,
            IRepository<HotelType, Guid> hotelTypeRepository,
             IGuidGenerator guidGenerator
            )
        {
            _hotelRepository = hotelRepository;
            _hotelTypeRepository = hotelTypeRepository;
            _guidGenerator = guidGenerator;
        }


        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _hotelTypeRepository.GetCountAsync() > 0)
            {
                return;
            }

            if (await _hotelRepository.GetCountAsync() > 0)
            {
                return;
            }


            var hotelTypes = new List<HotelType>() {
                    new HotelType {   Name="Business", Description="Business"    },
                    new HotelType {   Name="Airpot" , Description="Airpot"    },
                    new HotelType {   Name="Suite", Description="Suite"     },
                    new HotelType {   Name="Resort"  , Description="Resort"   },
                    new HotelType {   Name="Homestays"  , Description="Homestays"   },
                    new HotelType {   Name="Vacation Rentals"  , Description="Vacation Rentals"   },
                    new HotelType {   Name="Conference" , Description="Conference"    },
                };
            hotelTypes.ForEach(h => _hotelTypeRepository.InsertAsync(h, autoSave: true).GetAwaiter().GetResult());

            var hotels = new List<Hotel>() {
                    new Hotel {
                         Name = "Hotel Himalayan",
                         ShortDescription = "In the land of himalayan",
                         FullDescription = "In the land of himalayan",
                         ShowOnHomePage = true,
                         Rating=4,
                         AllowCustomerReviews=true,
                         IsEnabled=true,
                         HotelType = hotelTypes.FirstOrDefault(p=>p.Name =="Homestays"),
                         Address = new Address {
                              City = "Hetauda",
                              Province = "3",
                              District ="Makawanpur"
                         },
                         Location = new Location {
                              Latitude=87.6,
                              Longitude = 26.4
                         },

                         Rooms = new List<Room> {
                             new Room {
                                 Name="Everest",
                                 Capacity=3,
                                 MaxNoOfChildren=1,
                                 Price=1200,
                                 BedType = BedType.Double,
                                 IsSmoking=true,
                                 IsBooked =false
                             }
                         }
                    },
                      new Hotel {
                         Name = "Hotel Everest",
                         ShortDescription = "In the land of Everest",
                         FullDescription = "In the land of Everest",
                         ShowOnHomePage = true,
                         Rating=4,
                         AllowCustomerReviews=true,
                         IsEnabled=true,
                         HotelType = hotelTypes.FirstOrDefault(p=>p.Name =="Resort"),
                         Rooms = new List<Room> {
                             new Room {
                                 Name="Everest1122",
                                 Capacity=3,
                                 MaxNoOfChildren=1,
                                 Price=1200,
                                 BedType = BedType.Double,
                                 IsSmoking=true,
                                 IsBooked =false
                             }
                         },
                            Address = new Address {
                              City = "Hetauda",
                              Province = "3",
                              District ="Makawanpur"
                         },
                         Location = new Location {
                              Latitude=87.6,
                              Longitude = 26.4
                         }

                    },

                       new Hotel {
                         Name = "Hotel Avocado",
                         ShortDescription = "Hotel Avocado",
                         FullDescription = "Hotel Avocado",
                         ShowOnHomePage = true,
                         Rating=4,
                         AllowCustomerReviews=true,
                         IsEnabled=true,
                         HotelType = hotelTypes.FirstOrDefault(p=>p.Name =="Vacation Rentals"),
                         Rooms = new List<Room> {
                             new Room {
                                 Name="Hotel Avocado",
                                 Capacity=3,
                                 MaxNoOfChildren=1,
                                 Price=1200,
                                 BedType = BedType.Single,
                                 IsSmoking=true,
                                 IsBooked =false
                             }
                         } ,
                           Address = new Address {
                              City = "Hetauda",
                              Province = "3",
                              District ="Makawanpur"
                         },
                         Location = new Location {
                              Latitude=87.6,
                              Longitude = 26.4
                         },
                    },


            };

            hotels.ForEach(h => _hotelRepository.InsertAsync(h, autoSave: true).GetAwaiter().GetResult());

        }
    }
}
