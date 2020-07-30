using HotelApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class HotelAppController : AbpController
    {
        protected HotelAppController()
        {
            LocalizationResource = typeof(HotelAppResource);
        }
    }
}