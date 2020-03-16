using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThaniyasFarmerAppAPI.Models
{
    public class Sale : Base
    {

        [ForeignKey("LandDetailIDFK")]
        public LandDetail LandDetailsId { get; set; }

        [ForeignKey("PartitionLandDetailIDFK")]
        public PartitionLandDetail PartitionLandDetailId { get; set; }
        public string SaleDate { get; set; }
        [MaxLength(50)]
        public string Quantity { get; set; }
        [MaxLength(50)]
        public string Price { get; set; }
        [MaxLength(50)]
        public string BuyerName { get; set; }
        [MaxLength(50)]
        public string BuyerMobileNumber { get; set; }      
        public new bool Deleted { get; set; }

        public Sale()
        {
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
