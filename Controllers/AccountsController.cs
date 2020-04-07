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
        
    }
}
