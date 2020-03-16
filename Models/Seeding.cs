using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThaniyasFarmerAppAPI.Models
{
    public class Seeding : Base
    {
        [ForeignKey("LandDetailIDFK")]
        public LandDetail LandDetailsId { get; set; }

        [ForeignKey("PartitionLandDetailIDFK")]
        public PartitionLandDetail PartitionLandDetailId { get; set; }
        [MaxLength(50)]
        public string Quantity { get; set; }
        [MaxLength(50)]
        public string SeedName { get; set; }
        [MaxLength(50)]
        public string SeedCost { get; set; }
        [MaxLength(50)]
        public string NOofLabours { get; set; }
        public int LabourCost { get; set; }
        public new bool Deleted { get; set; }

        public Seeding()
        {
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
