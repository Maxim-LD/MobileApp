using System;

namespace MobileApp.Model.Entity
{
    public class ApplicationData
    {
        public Guid AccountId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public string AccountName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
    }
}
