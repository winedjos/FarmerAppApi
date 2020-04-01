using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThaniyasFarmerAppAPI.Models 
{
    public class PartitionLandDetail : Base
    {
        [Required]
        [MaxLength(75)]
        public string LandDirection { get; set; }
        
        [Required]
        [MaxLength(75)]
        public string AreaSize { get; set; }
        
        [ForeignKey("LandDetailId")]
        public  LandDetail LandDetail { get; set; }
       // public virtual LandDetail LandDetail { get; set; }
        
        public new bool Deleted { get; set; }
        public PartitionLandDetail()
        {
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
