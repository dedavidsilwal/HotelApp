using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HotelApp.Hotels
{
    public class HotelType : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Hotel Hotel { get; set; }
    }
}
