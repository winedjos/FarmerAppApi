using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Services.Interfaces
{
    public interface IEmailService
    {
        void AppSettings(out string UserID, out string Password, out string SMTPPort, out string Host);
        void SendEmail(string Subject, string Body, string To, string UserID, string Password, string SMTPPort, string Host, Attachment AttachmentFile = null);
    }
}
