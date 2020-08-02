using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HotelApp.Rooms
{
    public class ServicePerRoom : AuditedAggregateRoot<Guid>
    {
        public Guid RoomTypeId { get; set; }
        public Guid ServiceId { get; set; }

        //public RoomService Service { get; set; }

        //public RoomType RoomType { get; set; }
    }
}
