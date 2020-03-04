using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models
{
    public class Configuration:Base
    {   
        public string Type { get; set; }
        public int? ParentID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }
        public Configuration()
        {
            Deleted = false;
            DateAdded = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
        }
    }
}
