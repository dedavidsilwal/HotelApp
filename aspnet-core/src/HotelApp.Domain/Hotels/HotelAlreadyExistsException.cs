using Volo.Abp;

namespace HotelApp.Hotels
{
    public class HotelAlreadyExistsException : BusinessException
    {
        public HotelAlreadyExistsException(string name)
            : base(HotelAppDomainErrorCodes.HotelAlreadyExists)
        {
            WithData("name", name);
        }
    }

}
