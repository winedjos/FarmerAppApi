using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThaniyasFarmerAppAPI.Models
{
    public class Plowing : Base
    {

        [ForeignKey("LandDetailIDFK")]
        public LandDetail LandDetailsId { get; set; }

        [ForeignKey("PartitionLandDetailIDFK")]
        public PartitionLandDetail PartitionLandDetailId { get; set; }
        public DateTime PlowingDate { get; set; }
        [MaxLength(50)]
        public string TypeofPlowing { get; set; }
        [MaxLength(50)]
        public string PlowingExp { get; set; }
        [MaxLength(50)]
        public new bool Deleted { get; set; }

        public Plowing()
        {
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
