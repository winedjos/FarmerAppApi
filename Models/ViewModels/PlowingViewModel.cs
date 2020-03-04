using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class PlowingViewModel
    {
        public int PartitionLandDetailsId { get; set; }
        public int LandDetailsId { get; set; }
        public int ID { get; set; }
        public string Date { get; set; }
        [MaxLength(50)]
        public string TypeofPlowing { get; set; }
        [MaxLength(50)]
        public string PlowingExp { get; set; }
        [MaxLength(50)]
        public bool Deleted { get; set; }
    }
}
