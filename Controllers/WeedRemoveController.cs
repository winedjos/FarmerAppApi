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
    public class WeedRemoveController : ControllerBase
    {
        private readonly BaseDbContext _context;

        public WeedRemoveController(BaseDbContext context)
        {
            _context = context;
        }

        [HttpPost("add-WeedRemove")]
        public async Task<ActionResult<WeedRemove>> AddWeedRemove(WeedRemoveViewModel input)
        {
            //var weedRemove = input.Adapt<WeedRemove>();
            //_context.WeedRemove.Add(weedRemove);
            //await _context.SaveChangesAsync();

            //return new JsonResult(weedRemove); 
            try
            {
                WeedRemove weedRemove = null;
                if (input != null)
                {
                    weedRemove = input.Adapt<WeedRemove>();
                    //Getting Land detail
                    var landDetail = _context.LandDetails.Where(s => s.ID == input.LandDetailsId).FirstOrDefault();
                    if (landDetail == null) return new JsonResult(new { ErrorMessage = "The given land details id not found." });
                    var PartLandDetails = _context.PartitionLandDetails.Where(p => p.ID == input.PartitionLandDetailsId).FirstOrDefault();
                    if (PartLandDetails == null) return new JsonResult(new { ErrorMessage = "The given land details id not found." });

                    //Setting the land detail value to the Partition Land detail object
                    weedRemove.LandDetailsId = landDetail;
                    weedRemove.PartitionLandDetailId = PartLandDetails;

                    //Deciding whether the action is Add or Update
                    if (input.ID <= 0) //Add
                    {
                        _context.WeedRemove.Add(weedRemove);
                    }
                    else
                    { //Update
                        _context.WeedRemove.Update(weedRemove);
                    }
                }
                await _context.SaveChangesAsync();
                var result = GetWeedRemove(weedRemove.ID);
                return new JsonResult(weedRemove);
            }
            catch (Exception _ex)
            {
                return new JsonResult(new { ErrorMessage = _ex.Message });
            }



        }

        [HttpGet("WeedRemove-list")]
        public async Task<ActionResult<IEnumerable<WeedRemove>>> GetWeedRemoveActivity()
        {
          
                return await _context.WeedRemove.ToListAsync(); 
           
           
        }

        [HttpGet("get-WeedRemove/{id}")]
        public async Task<ActionResult<WeedRemoveEditViewModel>> GetWeedRemove(int id)
        {
            var WeedRemove = await _context.WeedRemove.FindAsync(id);
            WeedRemoveEditViewModel weedRemoveEditViewModel = null;

            if (WeedRemove != null)
            {
                var landDetails = _context.LandDetails.ToList();
                var partLandDetails = _context.PartitionLandDetails.ToList();
                weedRemoveEditViewModel = new WeedRemoveEditViewModel();
                weedRemoveEditViewModel.ID = WeedRemove.ID;
                weedRemoveEditViewModel.LabourCost = WeedRemove.LabourCost;
                weedRemoveEditViewModel.NOofLabours = WeedRemove.NOofLabours;
                weedRemoveEditViewModel.Date = WeedRemove.Date;
                weedRemoveEditViewModel.Cost = WeedRemove.Cost;
                weedRemoveEditViewModel.LandDetailName = landDetails;
                weedRemoveEditViewModel.selectedLandDetailId = WeedRemove.LandDetailsId.ID;
                weedRemoveEditViewModel.PartLandDetailName = partLandDetails;
                weedRemoveEditViewModel.selectedPartLandDetailId = WeedRemove.PartitionLandDetailId.ID;
            }

            return weedRemoveEditViewModel;
        }


        [HttpDelete("delete-WeedRemove/{id}")]
        public async Task<ActionResult<WeedRemove>> DeleteWeedRemove(int id)
        {
            var weedremove = await _context.WeedRemove.FindAsync(id);
            if (weedremove == null)
            {
                return NotFound();
            }

            _context.Entry(weedremove).State = EntityState.Modified;

            weedremove.Deleted = true;

            await _context.SaveChangesAsync();

            return weedremove;
        }

    }
}
