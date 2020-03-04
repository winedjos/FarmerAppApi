using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models
{
    public class LandDetails:Base
    {       
        [Required]
        [MaxLength(75)]
        public string Name { get; set; }

        [Required]
        [MaxLength(75)]
        public string State { get; set; }

        [Required]
        [MaxLength(100)]
        public string Village { get; set; }

        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(50)]
        public string PattaNumber { get; set; }
        public int AreaSize { get; set; }
       // public string Unit { get; set; }

        public LandDetails()
        {
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
