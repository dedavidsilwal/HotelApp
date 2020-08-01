using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace HotelApp.Hotels
{
    public class HotelManager : DomainService
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }


        public async Task<Hotel> CreateAsync(
            [NotNull] string name
            )
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var existingAuthor = await _hotelRepository.FindByNameAsync(name);
            if (existingAuthor != null)
            {
                throw new HotelAlreadyExistsException(name);
            }

            //return new Hotel(
            //        GuidGenerator.Create(),
            //        name
            //        );

            return default;
        }


    //    public async Task ChangeNameAsync(
    //[NotNull] Author author,
    //[NotNull] string newName)
    //    {
    //        Check.NotNull(author, nameof(author));
    //        Check.NotNullOrWhiteSpace(newName, nameof(newName));

    //        var existingAuthor = await _authorRepository.FindByNameAsync(newName);
    //        if (existingAuthor != null && existingAuthor.Id != author.Id)
    //        {
    //            throw new AuthorAlreadyExistsException(newName);
    //        }

    //        author.ChangeName(newName);
    //    }
    }
}
