using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThaniyasFarmerAppAPI.Models;

namespace ThaniyasFarmerAppAPI.Services.Interfaces
{
    public interface IAccountsServices
    {
        Task<LoginResults> Login(LoginInput input);
        string CreatePassword(int length);
        Task<string> AddResetToken(string email);
        Task<bool> ResetPassword(string email, string code, string password);
        Task<bool> CheckResetPasswordToken(string code, string email);
        Task<Status> UpdateTAndCAndFirstTimeLogin(PostLoginViewModel input);
    }
}
