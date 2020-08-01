using System;
using Volo.Abp.Application.Dtos;

namespace HotelApp.Hotels
{
    public class HotelAddressDto : EntityDto<Guid>
    {
        public string Province { get; set; }
        public string District { get; set; }
        public string City { get; set; }

        public Guid HotelId { get; set; }

        public HotelDto Hotel { get; set; }
    }



}
