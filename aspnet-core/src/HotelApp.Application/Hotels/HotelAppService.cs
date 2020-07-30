using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HotelApp.Hotels
{
    public class HotelAppService : CrudAppService<Hotel, HotelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateHotelDto>, IHotelAppService
    {
        public HotelAppService(IRepository<Hotel, Guid> repository)
            : base(repository)
        {

        }
    }
}
