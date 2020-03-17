using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThaniyasFarmerAppAPI.Models;
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
    public class StateListController : ControllerBase
    {
        private readonly BaseDbContext _context;

        public StateListController(BaseDbContext context)
        {
            _context = context;
        }

      

        [HttpGet("get-StateList")]
        public async Task<ActionResult<IEnumerable<StateList>>> GetStateListActivity()
        {
            return await _context.StateLists.ToListAsync();
        }
    }
}
