using ThaniyasFarmerAppAPI.Models;
using ThaniyasFarmerAppAPI.Repository;
using ThaniyasFarmerAppAPI.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace ThaniyasFarmerAppAPI.Services
{
    public class AccountsServices: IAccountsServices
    {
        private readonly IConfiguration _configuration;
        private readonly BaseDbContext _context;

        public AccountsServices(IConfiguration _configuration, BaseDbContext context)
        {
            this._configuration = _configuration;
            this._context = context;
        }
        public async Task<LoginResults> Login(LoginInput input)
        {
            var result = new Status();
            var returnResults = new LoginResults { status = new Status(), userDetail = new UserViewModel() };
            try
            {
                var password = Helpers.StringCipher.Encrypt(input.Password);
                var user = _context.Users.Where(x=> x.UserName== input.UserName && x.Password== password && !x.Deleted).FirstOrDefault();
                if (user!=null)
                {
                    returnResults.userDetail = user.Adapt<UserViewModel>();
                    //var pageAccess = _context.RolePageAccesses.Where(x => x.RolesID == user.RoleID).Select(x=>x.Pages).ToList();
                    //returnResults.userDetail.WebPages = pageAccess;
                       result = new Status { StatusCode = 200, StatusDisplay = "Logged in Successfully", StatusValue = true };
                }
                else
                {
                    result = new Status { StatusCode = 198, StatusDisplay = "UserName and Password does not match", StatusValue = false };
                }                
            }
            catch(Exception ex)
            {
                result = new Status { StatusCode = 500, StatusDisplay = ex.Message, StatusValue = false };
            }
            returnResults.status = result;
            return returnResults;
        }

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

    }
}
