using HotelApp.Hotels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HotelApp.Frontends
{
    public interface IFrontendAppService : IApplicationService
    {
        Task<List<string>> GetHotelAddressAsync(string search);
        Task<List<string>> GetListHotelTypeAsync();
        Task<List<string>> GetListHotelServiceAsync();
        Task<HotelDto> GetHotelAsync(Guid id);
        Task<PagedResultDto<HotelSearchResultDto>> GetHotelListAsync(HotelSearchQueryDto input);
    }
}
