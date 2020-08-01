using HotelApp.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace HotelApp.Hotels
{
    public class HotelAppService : CrudAppService<Hotel, HotelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateHotelDto>, IHotelAppService
    {
        private readonly IRepository<Address, Guid> _addressRepository;
        private readonly IAsyncQueryableExecuter _asyncExecuter;

        public HotelAppService( 
            IRepository<Hotel, Guid> hotelRepository,
            IRepository<Address, Guid> addressRepository,
            IAsyncQueryableExecuter asyncExecuter
            )
            : base(hotelRepository)
        {
            GetPolicyName = HotelAppPermissions.Hotels.Default;
            GetListPolicyName = HotelAppPermissions.Hotels.Default;
            CreatePolicyName = HotelAppPermissions.Hotels.Create;
            UpdatePolicyName = HotelAppPermissions.Hotels.Edit;
            DeletePolicyName = HotelAppPermissions.Hotels.Delete;


            _addressRepository = addressRepository;
            _asyncExecuter = asyncExecuter;
        }




        //public async Task<CreateUpdateHotelDto> GetEditEntityByIdAsync(Guid id)
        //{
        //    return ObjectMapper.Map<Hotel, CreateUpdateHotelDto>(await _repository.GetAsync(x => x.Id == id));
        //}


    }
}
