using System;
using Volo.Abp.Application.Dtos;

namespace HotelApp.Frontends
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
}
