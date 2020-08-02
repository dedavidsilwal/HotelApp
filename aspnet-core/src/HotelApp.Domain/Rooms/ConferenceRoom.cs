using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HotelApp.Rooms
{
    public class ConferenceRoom : AuditedAggregateRoot<Guid>
    {
        public Guid HotelId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Rating { get; set; }
        public float PricePerHour { get; set; }
    }
}
