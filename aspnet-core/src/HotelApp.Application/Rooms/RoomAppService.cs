using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HotelApp.Rooms
{
    public class RoomAppService : CrudAppService<Room, RoomDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateRoomDto>
    {
        public RoomAppService(IRepository<Room, Guid> repository) : base(repository)
        {
        }
    }
}
