using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class WeedRemoveEditViewModel
    {
        public int selectedLandDetailId { get; set; }
        public List<LandDetails> LandDetailName { get; set; }
        public int selectedPartLandDetailId { get; set; }
        public List<PartitionLandDetail> PartLandDetailName { get; set; }
        public int ID { get; set; }
        public string Date { get; set; }
        public string Cost { get; set; }
        public string NOofLabours { get; set; }
        public int LabourCost { get; set; }
    }
}
