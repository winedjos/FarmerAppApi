using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models
{
    public class UserActivity
    {
        [Key]
        public int ID { get; set; }

        public User User { get; set; }
        [ForeignKey("UserIDFK")]
        public int UserID { get; set; }

        public DateTime TimeStamp { get; set; }

        [Required]
        [MaxLength(500)]
        public string Activity { get; set; }
    }
}
