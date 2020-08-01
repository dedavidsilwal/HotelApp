using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HotelApp.Hotels
{
    public class ContactPerson : FullAuditedAggregateRoot<Guid>
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Designation { get; set; }

        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }


    }
}
