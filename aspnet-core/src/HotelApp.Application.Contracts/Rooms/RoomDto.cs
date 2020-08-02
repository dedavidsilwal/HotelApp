using HotelApp.Hotels;
using System;
using Volo.Abp.Application.Dtos;

namespace HotelApp.Rooms
{
    public class RoomDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public int MaxNoOfChildren { get; set; }
        public string DefaultPicture { get; set; }

        public decimal Price { get; set; }

        public BedType BedType { get; set; }
        public bool? IsSmoking { get; set; }

        public bool IsBooked { get; set; }

        public Guid HotelId { get; set; }
        public HotelDto Hotel { get; set; }
    }
}
