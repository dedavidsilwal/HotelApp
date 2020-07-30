using System;
using Volo.Abp.Application.Dtos;

namespace HotelApp.Hotels
{

    public class HotelDto : AuditedEntityDto<Guid>

    {

        public string Name { get; set; }
        public string Location { get; set; }


        public bool IsEnabled { get; set; }
        public HotelType Type { get; set; }


        public string ContactPerson { get; set; }
    }


}
