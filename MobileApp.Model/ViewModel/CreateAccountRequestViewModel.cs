using System;

namespace MobileApp.Model.ViewModel
{
    public class CreateAccountRequestViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; } 
        public string Nationality { get; set; }
        public string Gender { get; set; }
    }
}
