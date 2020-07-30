using System.ComponentModel.DataAnnotations;

namespace HotelApp.Hotels
{
    public class CreateUpdateHotelDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }


        public bool IsEnabled { get; set; }


        public HotelType Type { get; set; }


        public string ContactPerson { get; set; }
    }


}
