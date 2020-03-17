using ThaniyasFarmerAppAPI.Models;
using ThaniyasFarmerAppAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Data
{
    public class DbInitializer
    {
        public static void Initialize(BaseDbContext context)
        {
            //try
            //{
            //    context.Database.EnsureCreated();

            //    if (!context.LandDetails.Any())
            //    {
            //        var LandDetail = new LandDetail
            //        {
            //            ID = 1,
            //            Name = "Elco"
            //        };

            //        context.LandDetails.Add(LandDetail);
            //        context.SaveChanges();
            //    }

            //    if (!context.Users.Any())
            //    {
            //        var adminUser = new User
            //        {
            //            ID = 1,
            //            UserName = "admin",
            //            LandDetailID = 1
            //        };

            //        context.Users.Add(adminUser);
            //        context.SaveChanges();
            //    }


            //-
            //catch (Exception ex)
            //{

            //}
        }
    }
}
