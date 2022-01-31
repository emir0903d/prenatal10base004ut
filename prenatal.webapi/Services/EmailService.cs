using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public class EmailService:IEmailService
    {
        public bool Send(string to_name, string to_address, string msg)
        {
            if (to_name == null || to_address == null || msg == null)
            {
                return false;
            }

            var fromAddress = new MailAddress("prenatal.sa@gmail.com", "PRENATAL-SA");
            var toAddress = new MailAddress(to_address, to_name);
            //const string fromPassword = "P#renatal12345";
            const string subject = "PRENATAL: Confirmation E-mail";
            string body = msg;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("prenatal.sa@gmail.com", "P#renatal12345"),
                Timeout = 20000,

            };
            var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            };
            smtp.Send(message);

            return true;
        }
    }
}
