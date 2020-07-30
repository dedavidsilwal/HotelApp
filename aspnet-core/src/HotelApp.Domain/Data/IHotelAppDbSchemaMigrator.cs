using System.Threading.Tasks;

namespace HotelApp.Data
{
    public interface IHotelAppDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
