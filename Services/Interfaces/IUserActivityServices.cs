using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ThaniyasFarmerAppAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ThaniyasFarmerAppAPI.Services.Interfaces
{
    public interface IUserActivityServices
    {
        Task AddActivityLog(int userId, ActionExecutedContext response);
    }
}
