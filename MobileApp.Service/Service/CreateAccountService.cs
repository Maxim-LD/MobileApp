using MobileApp.Model.Entity;
using MobileApp.Model.ViewModel;
using MobileApp.Service.Interface;
using System;

namespace MobileApp.Service.Service
{
    public class CreateAccountService: ICreateAccountService
    {
        public new BaseResponseViewModel CreateAccount(CreateAccountRequestViewModel model)
        {
            var request = new ApplicationData();

            request.Id = Guid.NewGuid();
            request.FirstName = model.FirstName;
            request.LastName = model.LastName;
            request.DateOfBirth = model.DateOfBirth;
            request.Gender = model.Gender;
            request.DateCreated = DateTime.Now;
            request.Nationality = model.Nationality;
            request.PhoneNumber = model.PhoneNumber;
            request.Email = model.Email;


           
            return new BaseResponseViewModel { Status = true, Message = "Account Generated!" };
        } 
    }
}
