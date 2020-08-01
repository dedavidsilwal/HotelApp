using System;
using Volo.Abp.Application.Dtos;

namespace HotelApp.Hotels
{
    public class HotelLocationDto : EntityDto<Guid>
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Guid HotelId { get; set; }
        public HotelDto Hotel { get; set; }
    }



}
