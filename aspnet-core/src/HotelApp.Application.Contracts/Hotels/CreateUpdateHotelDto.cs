using System.ComponentModel.DataAnnotations;

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



}
