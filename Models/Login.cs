using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models
{
    public class Login:Base
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public string Password { get; set; }
        public new bool Deleted { get; set; }
        public Login()
        {            
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
