using HotelApp.Hotels;
using System;

namespace HotelApp.Rooms
{
    public class CreateUpdateRoomDto
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
    }
}
