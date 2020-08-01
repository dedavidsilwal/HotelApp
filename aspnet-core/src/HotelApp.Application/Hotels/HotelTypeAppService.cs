using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HotelApp.Hotels
{
    public class HotelTypeAppService : CrudAppService<HotelType, HotelTypeDto, Guid, PagedAndSortedResultRequestDto, HotelTypeDto>
    {
        public HotelTypeAppService(
               IRepository<HotelType, Guid> hoteltypeRepository):base(hoteltypeRepository)
        {

        }
    }
}
