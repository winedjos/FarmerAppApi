using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models
{
    public class RolePageAccess:Base
    {
        public Roles Roles { get; set; }
        [ForeignKey("RoleIDFK")]
        public int RolesID { get; set; }
        public WebPages Pages { get; set; }
        [ForeignKey("PageIDFK")]
        public int PagesID { get; set; }
        public RolePageAccess()
        {
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
