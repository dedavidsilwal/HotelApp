using System;
using System.Collections.Generic;
using System.Text;
using HotelApp.Localization;
using Volo.Abp.Application.Services;

namespace HotelApp
{
    /* Inherit your application services from this class.
     */
    public abstract class HotelAppAppService : ApplicationService
    {
        protected HotelAppAppService()
        {
            LocalizationResource = typeof(HotelAppResource);
        }
    }
}
