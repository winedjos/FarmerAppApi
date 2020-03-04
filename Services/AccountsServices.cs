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
                    var pageAccess = _context.RolePageAccesses.Where(x => x.RolesID == user.RoleID).Select(x=>x.Pages).ToList();
                    returnResults.userDetail.WebPages = pageAccess;
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

        public async Task<string> AddResetToken(string email)
        {
            var result = false;
            string token = "";

            var user = _context.Users.Where(x => x.Email == email && !x.Deleted).FirstOrDefault();
            if (user != null)
            {                
                //Generate reset token
                token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
                token= Regex.Replace(token, @"[^0-9a-zA-Z]+", "").ToLower();
                try
                {
                    user.ResetPasswordToken = token;
                    _context.Entry(user).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    result = true;
                }                
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            if (result)
            {
                return token;
            }

            return result.ToString();
        }

        public async Task<bool> ResetPassword(string email, string code, string password)
        {
            var result = false;
            var user = _context.Users.Where(x => x.Email == email && x.ResetPasswordToken == code && !x.Deleted).FirstOrDefault();
            if (user != null)
            {                                
                try
                {
                    user.ResetPasswordToken = "";
                    user.Password = Helpers.StringCipher.Encrypt(password); ;
                    _context.Entry(user).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        public async Task<Status> UpdateTAndCAndFirstTimeLogin(PostLoginViewModel input)
        {
            var result = new Status();
            var user = _context.Users.Where(x => x.ID == input.UserId).FirstOrDefault();
            if (user != null)
            {
                try
                {                    
                    user.IsFirstTimeLogin = input.IsFirstTimeLogin;
                    user.AcceptedTermsAndConditions = input.AcceptedTermsAndConditions;
                    _context.Entry(user).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    result = new Status { StatusCode = 200, StatusDisplay = "Logged in Successfully", StatusValue = true };
                }
                catch (Exception ex)
                {
                    result = new Status { StatusCode = 500, StatusDisplay = ex.Message, StatusValue = false };
                }
            }
            else
            {
                result = new Status { StatusCode = 404, StatusDisplay = "No Data Found", StatusValue = false };
            }

            return result;
        }

        public async Task<bool> CheckResetPasswordToken(string code, string email)
        {
            var result = false;

            var user = _context.Users.Where(x => x.Email == email && x.ResetPasswordToken == code && !x.Deleted).FirstOrDefault();

            if (user!=null)
            {
                result = true;
            }

            return result;
        }
    }
}
