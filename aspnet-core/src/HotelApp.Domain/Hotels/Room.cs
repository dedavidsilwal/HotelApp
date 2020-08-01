using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HotelApp.Hotels
{
    public class Room : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public int MaxNoOfChildren { get; set; }
        public string DefaultPicture { get; set; }

        //roomno

        public decimal Price { get; set; }

        public BedType BedType { get; set; }
        public bool? IsSmoking { get; set; }

        public bool IsBooked { get; set; }

        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }

    }
}
