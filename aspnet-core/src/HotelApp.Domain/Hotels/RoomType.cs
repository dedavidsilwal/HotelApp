using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace HotelApp.Hotels
{
    public class RoomType : AuditedAggregateRoot<Guid>
    {
        public Guid HotelId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public float Price { get; set; }
        public BedType BedType { get; set; }


        public IEnumerable<ServicePerRoom> Services { get; set; }
    }
}
