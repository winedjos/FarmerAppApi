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
    [ActionFillter]
    public class ViewReportController : Controller
    {
        private readonly BaseDbContext _context;

        public ViewReportController(BaseDbContext context)
        {
            _context = context;
        }

        [HttpGet("get-viewreports")]
        public async Task<ActionResult<IEnumerable<ViewReportViewModel>>> GetViewReport(int id)
        {
            LandDetail landDetailViewModel = await _context.LandDetails.FindAsync(id);
            PartitionLandDetail partitionLandViewModel = await _context.PartitionLandDetails.Where(p => p.LandDetailId == id).FirstOrDefaultAsync();
            List<Plowing> plowing = await _context.Plowings.Where(p => p.PartitionLandDetailId == partitionLandViewModel.ID).ToListAsync();
            List<Seeding> seeding = await _context.Seedings.Where(s => s.PartitionLandDetailId == partitionLandViewModel.ID).ToListAsync();
            List<PestControl> pestControl = await _context.PestControls.Where(p => p.PartitionLandDetailId == partitionLandViewModel.ID).ToListAsync();
            List<WeedRemove> weedRemove = await _context.WeedRemove.Where(p => p.PartitionLandDetailId == partitionLandViewModel.ID).ToListAsync();
            List<Sale> sale = await _context.Sales.Where(p => p.PartitionLandDetailId == partitionLandViewModel.ID).ToListAsync();
            List<Harvestings> harvestings = await _context.Harvestings.Where(p => p.PartitionLandDetailId == partitionLandViewModel.ID).ToListAsync();
            List<ViewReportViewModel> viewReportViewModel = new List<ViewReportViewModel>();
            foreach (var plow in plowing)
            {
                viewReportViewModel.Add(new ViewReportViewModel { 
                    Expense=plow.PlowingExp,
                    Income=0,
                    LandName= landDetailViewModel.Name,
                    Partition= partitionLandViewModel.LandDirection,
                    Purpose="Plowing"
                });
            
            }
           foreach(var seed in seeding)
            {
                viewReportViewModel.Add(new ViewReportViewModel
                {
                    Expense=seed.SeedCost + seed.LabourCost,
                    Income = 0,
                    LandName = landDetailViewModel.Name,
                    Partition = partitionLandViewModel.LandDirection,
                    Purpose = "Seeding"
                });
            }
            foreach (var pest in pestControl)
            {
                viewReportViewModel.Add(new ViewReportViewModel
                {
                    Expense = pest.LabourCost + pest.Cost,
                    Income = 0,
                    LandName = landDetailViewModel.Name,
                    Partition = partitionLandViewModel.LandDirection,
                    Purpose = "PestControl"
                });
            }
            foreach (var weed in weedRemove)
            {
                viewReportViewModel.Add(new ViewReportViewModel
                {
                    Expense = weed.Cost + weed.LabourCost,
                    Income = 0,
                    LandName = landDetailViewModel.Name,
                    Partition = partitionLandViewModel.LandDirection,
                    Purpose = "WeedRemove"
                });
            }
            foreach (var harvest in harvestings)
            {
                viewReportViewModel.Add(new ViewReportViewModel
                {
                    Expense = harvest.Cost + harvest.LabourCost,
                    Income = 0,
                    LandName = landDetailViewModel.Name,
                    Partition = partitionLandViewModel.LandDirection,
                    Purpose = "Sale"
                });
            }

            foreach (var sales in sale)
            {
                viewReportViewModel.Add(new ViewReportViewModel
                {
                    Expense = sales.Price,
                    Income = 0,
                    LandName = landDetailViewModel.Name,
                    Partition = partitionLandViewModel.LandDirection,
                    Purpose = "Harvesting"
                });
            }

            return viewReportViewModel;
        }

    }
}
    

