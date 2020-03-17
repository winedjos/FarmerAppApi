using ThaniyasFarmerAppAPI.Repository;
using ThaniyasFarmerAppAPI.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ThaniyasFarmerAppAPI.Services
{
    public class EmailService: IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly BaseDbContext _context;

        public EmailService(IConfiguration _configuration, BaseDbContext context)
        {
            this._configuration = _configuration;
            this._context = context;
        }
        //TO DO: We should use this approach for the web.config params elsewhere
        public void AppSettings(out string UserID, out string Password, out string SMTPPort, out string Host)
        {
            try
            {
                var configurations = this._context.Configurations.Where(x => x.Type == "SystemEmailSettings" && !x.Deleted).ToList();
                if (configurations.Any())
                {
                    UserID = Helpers.StringCipher.Decrypt(configurations.Find(x => x.Name == "UserID").Value);
                    Password = Helpers.StringCipher.Decrypt(configurations.Find(x => x.Name == "Password").Value);
                    SMTPPort = Helpers.StringCipher.Decrypt(configurations.Find(x => x.Name == "SMTPPort").Value);
                    Host = Helpers.StringCipher.Decrypt(configurations.Find(x => x.Name == "Host").Value);
                }
                else
                {
                    UserID = this._configuration["UserID"];
                    Password = this._configuration["Password"];
                    SMTPPort = this._configuration["SMTPPort"];
                    Host = this._configuration["Host"];
                }
            }
            catch(Exception ex)
            {
                UserID = "lpelliotthicks@gmail.com";
                Password = "Elliott123!1";
                SMTPPort = "587";
                Host = "smtp.gmail.com";
            }

        }
        
        public void SendEmail(string Subject, string Body, string To, string UserID, string Password, string SMTPPort, string Host, Attachment AttachmentFile = null)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(To);
            mail.From = new MailAddress(UserID);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = true;

            if (AttachmentFile != null)
            {
                mail.Attachments.Add(AttachmentFile);
            }

            SmtpClient smtp = new SmtpClient();
            smtp.Host = Host;
            smtp.Port = Convert.ToInt16(SMTPPort);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(UserID, Password);
            smtp.EnableSsl = true;
            smtp.Send(mail);

            // Need to enable this: https://myaccount.google.com/lesssecureapps

        }
    }
}
