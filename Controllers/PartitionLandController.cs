﻿using System;
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



namespace ThaniyasFarmerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class PartitionLandController : ControllerBase
    {
        private readonly BaseDbContext _context;

        public PartitionLandController(BaseDbContext context)
        {
            _context = context;
        }

        [HttpPost("add-PartitionLand")]
        public async Task<ActionResult<PartitionLandEditViewModel>> AddpartitionLand([FromBody]PartitionLandViewModel input)
        {
            
            try
            {
                if (isExists(input.LandDirection, input.UserId)&& input.ID == 0)
                {
                    return new JsonResult(new { status = true, ErrorMessage = "Already Exist" });
                }


                PartitionLandDetail partitionLandDetail = null;
                if (input != null)
                {
                    partitionLandDetail = input.Adapt<PartitionLandDetail>();
                    
                    var landDetail = _context.LandDetails.Where(s => s.ID == input.LandDetailId).FirstOrDefault();
                    if (landDetail == null) return new JsonResult(new { ErrorMessage = "The given land details id not found." });
                    var user = _context.Users.Where(s => s.ID == input.UserId).FirstOrDefault();
                    if (user == null) return new JsonResult(new { ErrorMessage = "The given user id not found." });
                    landDetail.User = user;    
                    partitionLandDetail.LandDetail = landDetail;
                   
                    if (input.ID <= 0) 
                    {
                        _context.PartitionLandDetails.Add(partitionLandDetail);
                    }
                    else
                    { 
                        _context.PartitionLandDetails.Update(partitionLandDetail);
                    }
                }
                await _context.SaveChangesAsync();
                
                return new JsonResult(partitionLandDetail);
            }
            catch (Exception _ex)
            {
                return new JsonResult(new { ErrorMessage = _ex.Message });
            }
        }

        [HttpGet("PartitionLand-list")]
        public async Task<ActionResult<List<PartitionLandDetail>>> GetPartLandActivity(int userId)
        {
            var partLandList = await _context.PartitionLandDetails.Where(d => d.Deleted == false && d.LandDetail.Deleted == false && d.UserId == userId)
                    .Include(p => p.LandDetail).ToListAsync();
            return partLandList.Where(x => x.UserId == userId).ToList();

        }
        [HttpGet("get-PartitionLand/{id}")]
        public async Task<ActionResult<PartitionLandEditViewModel>> GetPartLand(int id)
        {
            var PartLand = await _context.PartitionLandDetails.Where(a => a.ID == id).Include(l => l.LandDetail.State).FirstOrDefaultAsync();
            PartitionLandEditViewModel partitionLandEditViewModel = null;
            if (PartLand != null)
            {               
                var landDetails = _context.LandDetails.ToList();
                partitionLandEditViewModel = new PartitionLandEditViewModel();
                partitionLandEditViewModel.ID = PartLand.ID;
                partitionLandEditViewModel.AreaSize = PartLand.AreaSize;
                partitionLandEditViewModel.LandDirection = PartLand.LandDirection;
                partitionLandEditViewModel.Notes = PartLand.Notes;
                partitionLandEditViewModel.LandDetailName = landDetails;
                partitionLandEditViewModel.selectedLandDetailId = PartLand.LandDetail.ID;
                
            }
            return partitionLandEditViewModel;
        }


        [HttpDelete("delete-PartLand/{id}")]
        public async Task<ActionResult<PartitionLandDetail>> DeletePartitionLand(int id)
        {
            var PartLand = await _context.PartitionLandDetails.FindAsync(id);
            if (PartLand == null)
            {
                return NotFound();
            }

            _context.Entry(PartLand).State = EntityState.Modified;

            PartLand.Deleted = true;

            await _context.SaveChangesAsync();

            return PartLand;
        }


        private bool isExists(string landDirection, int userId)
        {
            var result = _context.PartitionLandDetails.Where(a => a.LandDirection.Equals(landDirection) && a.UserId==userId);
            if(result.Any())
            {
                return true;
            }
            return false;
        }

    }
}
