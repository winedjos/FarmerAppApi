﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThaniyasFarmerAppAPI.Models.ViewModels
{
    public class PestControlViewModel
    {
        public int PartitionLandDetailId { get; set; }
        public int ID { get; set; }
        public DateTime PestControlDate { get; set; }
        [MaxLength(50)]
        public string NameofthePestSide { get; set; }
       
        public float Cost { get; set; }
        [MaxLength(50)]
        public string Purpose { get; set; }
       
        public float LabourCost { get; set; }
        public string Notes { get; set; }       
        public bool Deleted { get; set; }
        public int UserId { get; set; }
    }
}
