using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models
{
    public class WebPages
    {
        [Key]
        public int ID { get; set; }        
        public string Name { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
        public bool Deleted { get; set; }
    }
}
