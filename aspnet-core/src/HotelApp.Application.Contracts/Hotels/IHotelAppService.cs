using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HotelApp.Hotels
{
    public interface IHotelAppService : ICrudAppService<HotelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateHotelDto>
    {

    }


}
