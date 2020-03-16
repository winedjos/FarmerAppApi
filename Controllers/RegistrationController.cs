using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThaniyasFarmerAppAPI.Models;
using ThaniyasFarmerAppAPI.Models.ViewModels;
using ThaniyasFarmerAppAPI.Repository;
using ThaniyasFarmerAppAPI.Filters;
using Microsoft.AspNetCore.Cors;
using Mapster;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ActionFillter]
    public class RegistrationController : Controller
    {
        private readonly BaseDbContext _context;

        public RegistrationController(BaseDbContext context)
        {
            _context = context;
        }


        [HttpPost("store-Registration")]
        public async Task<ActionResult<RegistrationController>> StoreRegistration(Registration registration)
        {
            _context.Registrations.Add(registration);
            await _context.SaveChangesAsync();

            return new JsonResult(registration);  
        }
    }
}
