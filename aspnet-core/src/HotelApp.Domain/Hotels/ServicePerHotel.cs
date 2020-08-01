using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HotelApp.Hotels
{
    public class ServicePerHotel : AuditedAggregateRoot<Guid>
    {
        public Guid HotelId { get; set; }
        public Guid ServiceId { get; set; }

        public HotelService Service { get; set; }

        public Hotel Hotel { get; set; }
    }
}
