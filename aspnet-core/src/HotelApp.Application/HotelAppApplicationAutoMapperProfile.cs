using AutoMapper;
using HotelApp.Hotels;
using HotelApp.HotelTypes;
using HotelApp.Rooms;

namespace HotelApp
{
    public class HotelAppApplicationAutoMapperProfile : Profile
    {
        public HotelAppApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Hotel, HotelDto>();
            CreateMap<CreateUpdateHotelDto, Hotel>();
            CreateMap<HotelAddressDto, Address>();
            CreateMap<HotelLocationDto, Location>();
            CreateMap<HotelTypeDto, HotelType>();

            CreateMap<Room, RoomDto>();
            CreateMap<CreateUpdateRoomDto, Room>();
        }
    }
}
