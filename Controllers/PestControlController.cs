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
    public class PestControlController : ControllerBase
    {

        private readonly BaseDbContext _context;

        public PestControlController(BaseDbContext context)
        {
            _context = context;
        }

        [HttpPost("add-PestControl")]
        public async Task<ActionResult<PestControl>> AddPestControl(PestControlViewModel input)
        {
            //_context.PestControls.Add(pestControl);
            //await _context.SaveChangesAsync();

            //return new JsonResult(pestControl);

            try
            {
                PestControl pestControl = null;
                if (input != null)
                {
                    pestControl = input.Adapt<PestControl>();
                    //Getting Land detail
                    var landDetail = _context.LandDetails.Where(s => s.ID == input.LandDetailsId).FirstOrDefault();
                    if (landDetail == null) return new JsonResult(new { ErrorMessage = "The given land details id not found." });
                    var PartLandDetails = _context.PartitionLandDetails.Where(p => p.ID == input.PartitionLandDetailsId).FirstOrDefault();
                    if (PartLandDetails == null) return new JsonResult(new { ErrorMessage = "The given land details id not found." });

                    //Setting the land detail value to the Partition Land detail object
                    pestControl.LandDetailsId = landDetail;
                    pestControl.PartitionLandDetailId = PartLandDetails;

                    //Deciding whether the action is Add or Update
                    if (input.ID <= 0) //Add
                    {
                        _context.PestControls.Add(pestControl);
                    }
                    else
                    { //Update
                        _context.PestControls.Update(pestControl);
                    }
                }
                await _context.SaveChangesAsync();
                return new JsonResult(pestControl);
            }
            catch (Exception _ex)
            {
                return new JsonResult(new { ErrorMessage = _ex.Message });
            }
        }

        [HttpGet("pestControl-list")]
        public async Task<ActionResult<IEnumerable<PestControl>>> GetPestControlActivity()
        {
            return await _context.PestControls.ToListAsync();
        }

        [HttpGet("get-PestControl/{id}")]
        public async Task<ActionResult<PestControl>> GetPestControl(int id)
        {
            var pestControl = await _context.PestControls.FindAsync(id);

            if (pestControl == null)
            {
                return NotFound();
            }
            return pestControl;
        }

        [HttpDelete("delete-PestControl/{id}")]
        public async Task<ActionResult<PestControl>> DeletePestControl(int id)
        {
            var pestControl = await _context.PestControls.FindAsync(id);
            if (pestControl == null)
            {
                return NotFound();
            }

            _context.Entry(pestControl).State = EntityState.Modified;

            pestControl.Deleted = true;

            await _context.SaveChangesAsync();

            return pestControl;
        }


    }
}
