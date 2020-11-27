﻿using System.Collections.Generic;
using ThaniyasFarmerAppAPI.Models;
using Microsoft.AspNetCore.Mvc;
using ThaniyasFarmerAppAPI.Services.Interfaces;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private IAccountsServices accountsServices;
        public LoginController(IAccountsServices _accountsServices)
        {
            accountsServices = _accountsServices;
        }

        [HttpPost("store-Login")]
        public async Task<IActionResult> Login(LoginInput login)
        {
            var returnResut = await accountsServices.Login(login);
            return new JsonResult(returnResut);
        }

    }
}
