using ThaniyasFarmerAppAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Filters
{
    public class ActionFilter : IAsyncActionFilter
    {
        private IUserActivityServices userActivityServices;
        public ActionFilter(IUserActivityServices _userActivityServices)
        {
            userActivityServices = _userActivityServices;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // execute any code before the action executes            
            var result = await next();
            try
            {
                var id = 0;
                if (context.HttpContext.Request.Query.Any())
                {
                    var query = context.HttpContext.Request.Query["auid"][0];
                    if (!string.IsNullOrEmpty(query))
                    {
                        id = int.Parse(query);
                    }
                    if (id != 0)
                    {
                        await userActivityServices.AddActivityLog(id, result);
                    }
                }
            }
            catch(Exception ex)
            {

            }
            
        }
    }

}
