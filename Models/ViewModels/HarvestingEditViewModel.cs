using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class HarvestingEditViewModel
    {
        public int selectedLandDetailId { get; set; }
        public int UserId { get; set; }
        public LandDetail LandDetailName { get; set; }
        public int selectedPartLandDetailId { get; set; }
        public PartitionLandDetail PartLandDetailName { get; set; }
        public int ID { get; set; }
        public string Date { get; set; }
        public string Cost { get; set; }
        public string NOofLabours { get; set; }
        public int LabourCost { get; set; }
    }
}
