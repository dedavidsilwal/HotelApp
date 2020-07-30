using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace HotelApp.Hotels
{
    public class HotelAppDataSeederContributor : IDataSeedContributor, ITransientDependency

    {
        private readonly IRepository<Hotel, Guid> _hotelRepository;

        public HotelAppDataSeederContributor(IRepository<Hotel, Guid> hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }


        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _hotelRepository.GetCountAsync() <= 0)
            {
                await _hotelRepository.InsertAsync(
                    new Hotel {
                        Name = "Smart Hotel",
                        Location = "Hetauda",
                        ContactPerson = "David Silwal",
                        IsEnabled = true,
                    }
                    , autoSave: true
                    );


                await _hotelRepository.InsertAsync(
                      new Hotel {
                          Name = "Smart Hotel 360",
                          Location = "Hetauda",
                          ContactPerson = "David Silwal",
                          IsEnabled = true,
                      }
                      , autoSave: true
                      );
            }
        }
    }
}
