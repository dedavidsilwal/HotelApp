using System;
using Volo.Abp.Application.Dtos;

namespace HotelApp.Hotels
{
    public class HotelTypeDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public HotelDto Hotel { get; set; }
    }



}
