using System;
using Volo.Abp.Domain.Entities;

namespace HotelApp.Hotels
{
    public class Location: AggregateRoot<Guid>
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
