using System;
using Volo.Abp.Domain.Entities;

namespace HotelApp.Hotels
{
    public class Address : AggregateRoot<Guid>
    {
        public string Province { get; set; }
        public string District { get; set; }
        public string City { get; set; }

        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }

    }
}
