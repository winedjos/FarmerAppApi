using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models
{
    public class User:Base
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public string Password { get; set; }
       
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

       // public int RoleID { get; set; }
        public bool IsFirstTimeLogin { get; set; }
      

        public User()
        {
            IsFirstTimeLogin = true;         
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }

    }
}
