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
        public async Task<ActionResult<IEnumerable<LandDetail>>> GetLandDetails()
        
        {
            try
            {
                var result = await _context.LandDetails.Where(d => d.Deleted == false)
                    .Include(p => p.PartitionLandDetails)
                    .Include(s=> s.State).ToListAsync();
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("get-LandDetail/{id}")]
        public async Task<ActionResult<LandDetailEditViewModel>> GetLandDetail(int id)
        {
            var LandDetail = await _context.LandDetails.FindAsync(id);
            LandDetailEditViewModel landDetailEditViewModel = null;
            if (LandDetail != null)
            {
                var stateList = _context.StateLists.ToList();
                landDetailEditViewModel = new LandDetailEditViewModel();
                landDetailEditViewModel.City = LandDetail.City;
                landDetailEditViewModel.Name = LandDetail.Name;
                landDetailEditViewModel.ID = LandDetail.ID;
                landDetailEditViewModel.PattaNumber = LandDetail.PattaNumber;               
                landDetailEditViewModel.Village = LandDetail.Village;
                landDetailEditViewModel.AreaSize = LandDetail.AreaSize;
                landDetailEditViewModel.States = stateList;
                landDetailEditViewModel.selectedStateListId = LandDetail.State.ID;
            }

            return landDetailEditViewModel;
        }


        [HttpPut("update-LandDetail/{id}")]
        public async Task<IActionResult> UpdateLandDetail(int id, LandDetail LandDetail)
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
        public async Task<ActionResult<LandDetail>> AddLandDetail([FromBody]LandDetailViewModel input)
        {
            //var landDetails = input.Adapt<LandDetail>();
            //_context.LandDetails.Add(landDetails);
            //await _context.SaveChangesAsync();
            //return new JsonResult(landDetails);
            // return CreatedAtAction("GetLandDetail", new { id = LandDetail.ID }, LandDetail);

            try
            {
                LandDetail landDetails = null;
                if (input != null)
                {
                    landDetails = input.Adapt<LandDetail>();
                    var stateList = _context.StateLists.Where(s => s.ID == input.StateId).FirstOrDefault();
                    if (stateList == null) return new JsonResult(new { ErrorMessage = "The given state id not found." });

                    //Setting the state List value to the Land detail object
                    landDetails.State = stateList;
                    if (input.ID <= 0) 
                    {
                        _context.LandDetails.Add(landDetails);
                    }
                    else
                    { //Update
                        _context.LandDetails.Update(landDetails);
                    }
                }
                await _context.SaveChangesAsync();
                var result = GetLandDetail(landDetails.ID);
                return new JsonResult(landDetails);
            }
            catch (Exception _ex)
            {
                return new JsonResult(new { ErrorMessage = _ex.Message });
            }

        }
        
        [HttpDelete("delete-LandDetail/{id}")]
        public async Task<ActionResult<LandDetail>> DeleteLandDetail(int id)   
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
