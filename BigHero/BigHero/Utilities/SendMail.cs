using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using BigHero.Models;

namespace BigHero.Utilities
{
    public static class SendMail
    {
        public static void Send(Item note,UserProfile userProfile)
        {
            var body = "<p>you have message {0}, at {1}, from {2} to {3}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress(userProfile.Email));  // replace with valid value 
            message.From = new MailAddress("1241009@student.hcmus.edu.vn");  // replace with valid value
            message.Subject = "Note";
            message.Body = string.Format(body, note.Note,note.Location,note.StartDate,note.EndDate);
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "1241009@student.hcmus.edu.vn",  // replace with valid value
                    Password = "123iloveyoU"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp-mail.outlook.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.SendMailAsync(message);
            }
        }
    }
}