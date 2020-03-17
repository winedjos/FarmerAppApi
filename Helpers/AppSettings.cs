using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Helpers
{
    public class AppSettings
    {
        public static string UserID
        {
            get; set;
        }

        public static string Password
        {
            get; set;
        }

        public static string SMTPPort
        {
            get; set;
        }

        public static string Host
        {
            get; set;
        }
    }
}
