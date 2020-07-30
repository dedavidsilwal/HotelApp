using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace HotelApp.Hotels
{
    public class Hotel : AuditedAggregateRoot<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; }


        public string Name { get; set; }
        public string Location { get; set; }


        public bool IsEnabled { get; set; }
        public HotelType Type { get; set; }


        public string ContactPerson { get; set; }

    }

    public class ContactPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Designation { get; set; }
    }
}
