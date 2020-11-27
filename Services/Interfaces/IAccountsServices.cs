using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThaniyasFarmerAppAPI.Models;
using ThaniyasFarmerAppAPI.Models.ViewModels;

namespace ThaniyasFarmerAppAPI.Services.Interfaces
{
    public interface IAccountsServices
    {
        Task<LoginResults> Login(LoginInput input);
        string CreatePassword(int length);
        Task<LoginResults> GoogleLogin(GoogleRegisterViewModel input);
            
    }
}
