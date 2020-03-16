using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThaniyasFarmerAppAPI.Models
{
    public class WeedRemove : Base
    {
        [ForeignKey("LandDetailIDFK")]
        public LandDetail LandDetailsId { get; set; }

        [ForeignKey("PartitionLandDetailIDFK")]
        public PartitionLandDetail PartitionLandDetailId { get; set; }
        public string Date { get; set; }

        [MaxLength(50)]
        public string Cost { get; set; }
        [MaxLength(50)]
        public string NOofLabours { get; set; }
        public int LabourCost { get; set; }
        public new bool Deleted { get; set; }

        public WeedRemove()
        {
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
