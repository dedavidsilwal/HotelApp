using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace HotelApp.Hotels
{
    public class CreateUpdateHotelDto
    {
        [Required]
        [StringLength(50)]
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

    public class HotelAddressDto : EntityDto<Guid>
    {
        public string Province { get; set; }
        public string District { get; set; }
        public string City { get; set; }

        public Guid HotelId { get; set; }

        public HotelDto Hotel { get; set; }
    }

    public class HotelLocationDto : EntityDto<Guid>
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Guid HotelId { get; set; }
        public HotelDto Hotel { get; set; }
    }

    public class HotelTypeDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public HotelDto Hotel { get; set; }
    }


}
