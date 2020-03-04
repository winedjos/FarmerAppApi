using System.Collections.Generic;
using ThaniyasFarmerAppAPI.Models;
using Microsoft.AspNetCore.Mvc;
using ThaniyasFarmerAppAPI.Services.Interfaces;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private IAccountsServices accountsServices;
        public AccountsController(IAccountsServices _accountsServices)
        {
            accountsServices = _accountsServices;
        }
        
        [HttpPost]
        public async Task<IActionResult> Login(LoginInput input)
        {
            var returnResut = await accountsServices.Login(input);
            return new JsonResult(returnResut);
        }


        [HttpPost]
        [Route("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPassword request)
        {
            var result = await accountsServices.ResetPassword(request.Email, request.Code, request.Password);
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("add-reset-token")]
        public async Task<IActionResult> AddResetToken(AddResetToken request)
        {
            var result = await accountsServices.AddResetToken(request.Email);

            return new JsonResult(result);
        }

        [HttpPost]
        [Route("check-reset-password-token")]
        public async Task<IActionResult> CheckResetPasswordToken(string code, string email)
        {
            var result = await accountsServices.CheckResetPasswordToken(code, email);
            return new JsonResult(result);
        }


        [HttpPost]
        [Route("update-tc-firsttime-login")]
        public async Task<IActionResult> UpdateTAndCAndFirstTimeLogin(PostLoginViewModel input)
        {
            var result = await this.accountsServices.UpdateTAndCAndFirstTimeLogin(input);
            return new JsonResult(result);
        }
    }
}
