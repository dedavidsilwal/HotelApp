using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace HotelApp.Hotels
{

    public class Hotel : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; }


        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }

        public bool ShowOnHomePage { get; set; }

        //float
        public int Rating { get; set; }


        public string DefaultPicture { get; set; }
        public bool AllowCustomerReviews { get; set; }


        public IEnumerable<ContactPerson> ContactPeoples { get; set; }
        public IEnumerable<Room> Rooms { get; set; }

        public bool HasUserAgreement { get; set; }
        public string UserAgreementText { get; set; }


        public TimeSpan CheckinTime { get; set; }
        public TimeSpan CheckoutTime { get; set; }


        public bool IsEnabled { get; set; }


        public Address Address { get; set; }
        public Location Location { get; set; }

        public Guid HotelTypeId { get; set; }

        public HotelType HotelType { get; set; }

    }
}
