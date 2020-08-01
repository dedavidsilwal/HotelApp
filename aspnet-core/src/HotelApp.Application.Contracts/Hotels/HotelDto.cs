using System;
using Volo.Abp.Application.Dtos;

namespace HotelApp.Hotels
{

    public class HotelDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }

        public bool IsEnabled { get; set; }

        public bool ShowOnHomePage { get; set; }

        public bool AllowCustomerReviews { get; set; }
        public string DefaultPicture { get; set; }

        public HotelAddressDto Address { get; set; }
        public HotelLocationDto Location { get; set; }

        public HotelTypeDto HotelType { get; set; }
    }
}
