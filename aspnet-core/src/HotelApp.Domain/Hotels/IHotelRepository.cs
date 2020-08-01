using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;

namespace HotelApp.Hotels
{
    public interface IHotelRepository : IRepository<Hotel, Guid>
    {
        Task<Hotel> FindByNameAsync(string name);

        Task<List<Hotel>> GetListAsync(
                int skipCount,
                int maxResultCount,
                string sorting,
                string filter = null
          );

    }

  

    public class HotelAlreadyExistsException : BusinessException
    {
        public HotelAlreadyExistsException(string name)
            : base(HotelAppDomainErrorCodes.HotelAlreadyExists)
        {
            WithData("name", name);
        }
    }

    public static class HotelAppDomainErrorCodes
    {
        public const string HotelAlreadyExists = "HotelApp:00001";
    }

}
