using System;
using Volo.Abp.Application.Dtos;

namespace HotelApp.Hotels
{
    public class HotelSearchQueryDto : PagedAndSortedResultRequestDto
    {
        public string Address { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public short Adults { get; set; }
        public short Children { get; set; }
        public short Rooms { get; set; }
        public string Filter { get; set; }
    }

    public class HotelSearchResultDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string BedType { get; set; }
        public decimal Price { get; set; }
    }
}
