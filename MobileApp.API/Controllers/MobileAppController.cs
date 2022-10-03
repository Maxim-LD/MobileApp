using Microsoft.AspNetCore.Mvc;
using MobileApp.Model.ViewModel;
using MobileApp.Service.Interface;

namespace MobileApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseResponseViewModel : ControllerBase
    {
        private readonly ICreateAccountService _createAccountService;
        public BaseResponseViewModel(ICreateAccountService createAccountService)
        {
            _createAccountService = createAccountService;
        }

        [HttpPost("CreateAccount")]
        public IActionResult CreateAccount(CreateAccountRequestViewModel model)
        {
            var result = _createAccountService.CreateAccount(model);
            return Ok(result);

        }
    }
}
