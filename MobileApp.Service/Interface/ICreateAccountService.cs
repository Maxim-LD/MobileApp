using MobileApp.Model.ViewModel;

namespace MobileApp.Service.Interface
{
    public interface ICreateAccountService
    {
        public BaseResponseViewModel CreateAccount(CreateAccountRequestViewModel model);
    }
}
