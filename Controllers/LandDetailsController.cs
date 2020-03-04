using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThaniyasFarmerAppAPI.Models;
using ThaniyasFarmerAppAPI.Models.ViewModels;
using ThaniyasFarmerAppAPI.Repository;

namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandDetailsController : ControllerBase
    {
        private readonly BaseDbContext _context;

        public LandDetailsController(BaseDbContext context)
        {
            _context = context;
        }

        [HttpGet("get-LandDetails")]
        public async Task<ActionResult<IEnumerable<LandDetails>>> GetLandDetails()
        
        {
            try
            {
                return await _context.LandDetails.Where(d => d.Deleted == false).ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("get-LandDetail/{id}")]
        public async Task<ActionResult<LandDetails>> GetLandDetail(int id)
        {
            var LandDetail = await _context.LandDetails.FindAsync(id);

            if (LandDetail == null)
            {
                return NotFound();
            }

            return LandDetail;
        }


        [HttpPut("update-LandDetail/{id}")]
        public async Task<IActionResult> UpdateLandDetail(int id, LandDetails LandDetail)
        {
            if (id != LandDetail.ID)
            {
                return BadRequest();
            }

            _context.Entry(LandDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LandDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost("add-LandDetail")]
        public async Task<ActionResult<LandDetails>> AddLandDetail([FromBody]LandDetailViewModel input)
        {
            var landDetails = input.Adapt<LandDetails>();
            _context.LandDetails.Add(landDetails);
            await _context.SaveChangesAsync();
            return new JsonResult(landDetails);
            // return CreatedAtAction("GetLandDetail", new { id = LandDetail.ID }, LandDetail);
        }
        
        [HttpDelete("delete-LandDetail/{id}")]
        public async Task<ActionResult<LandDetails>> DeleteLandDetail(int id)   
        {
            var LandDetail = await _context.LandDetails.FindAsync(id);
            if (LandDetail == null)
            {
                return NotFound();
            }

            _context.Entry(LandDetail).State = EntityState.Modified;

            LandDetail.Deleted = true;

            await _context.SaveChangesAsync();

            return LandDetail;
        }

        private bool LandDetailExists(int id)
        {
            return _context.LandDetails.Any(e => e.ID == id);
        }
    }
}
