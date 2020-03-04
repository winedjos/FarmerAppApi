using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models
{
    public class Harvestings:Base
    {

        [ForeignKey("LandDetailIDFK")]
        public LandDetails LandDetailsId { get; set; }

        [ForeignKey("PartitionLandDetailIDFK")]
        public PartitionLandDetail PartitionLandDetailId { get; set; }     
        public string Date { get; set; }

        [MaxLength(50)]
        public string Cost { get; set; }
        [MaxLength(50)]
        public string NOofLabours { get; set; }
        public int LabourCost { get; set; }         
        public Harvestings()
        {
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
