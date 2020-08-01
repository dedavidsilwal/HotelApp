using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;


namespace HotelApp.Hotels
{
    public class FrontendAppService : ApplicationService, IFrontendAppService
    {
        private readonly IReadOnlyRepository<Hotel, Guid> _hotelRepository;
        private readonly IReadOnlyRepository<HotelType, Guid> _hotelTypeRepository;
        private readonly IReadOnlyRepository<Address, Guid> _addressRepository;
        private readonly IAsyncQueryableExecuter _asyncExecuter;

        public FrontendAppService(
            IReadOnlyRepository<Hotel, Guid> hotelRepository,
            IReadOnlyRepository<HotelType, Guid> hotelTypeRepository,
            IReadOnlyRepository<Address, Guid> addressRepository,
            IAsyncQueryableExecuter asyncExecuter)
        {
            _hotelRepository = hotelRepository;
            _hotelTypeRepository = hotelTypeRepository;
            _addressRepository = addressRepository;
            _asyncExecuter = asyncExecuter;
        }

        public async Task<PagedResultDto<HotelSearchResultDto>> GetHotelListAsync(HotelSearchQueryDto input)
        {

            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Hotel.Name);
            }

            var query = _hotelRepository
                .OrderBy(input.Sorting)
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);

            var totalCount = await _asyncExecuter.CountAsync(query);

            var hotels = await _asyncExecuter.ToListAsync(query);

            var hotelsDto = ObjectMapper.Map<List<Hotel>, List<HotelSearchResultDto>>(hotels);

            return new PagedResultDto<HotelSearchResultDto>(
                totalCount,
                hotelsDto
            );

        }

        public async Task<List<string>> GetHotelAddressAsync(string search)
        {
            var query = _addressRepository
                      .WhereIf(!search.IsNullOrEmpty(), a => a.City.Contains(search))
                      .Select(s => s.City).OrderBy(s => s);

            return await _asyncExecuter.ToListAsync(query);
        }


        public async Task<List<string>> GetListHotelTypeAsync()
        {
            var query = _hotelTypeRepository
                        .Select(s => s.Name)
                        .OrderBy(s => s);

            return await _asyncExecuter.ToListAsync(query);
        }

        public Task<List<string>> GetListHotelServiceAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<HotelDto> GetHotelAsync(Guid id)
        {
            var hotel = await _hotelRepository.GetAsync(id);

            return ObjectMapper.Map<Hotel, HotelDto>(hotel);
        }
    }
}
