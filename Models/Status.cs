using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Models
{
    public class Status
    {
        public int StatusCode { set; get; }
        public bool StatusValue { set; get; }
        public string StatusDisplay { set; get; }        
    }

    public class StatusResponse
    {
        public Status Status { get; set; }
    }
}
