using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class SalesViewModel
    {
        public int PartitionLandDetailsId { get; set; }
        public int LandDetailsId { get; set; }
        public int ID { get; set; }
        public string Date { get; set; }
        [MaxLength(50)]
        public string Quantity { get; set; }
        [MaxLength(50)]
        public string Price { get; set; }
        [MaxLength(50)]
        public string BuyerName { get; set; }
        [MaxLength(50)]
        public string BuyerMobileNumber { get; set; }
        public bool Deleted { get; set; }
    }
}
