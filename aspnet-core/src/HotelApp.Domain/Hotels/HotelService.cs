using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HotelApp.Hotels
{
    public class HotelService : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
    }
}
