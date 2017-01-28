using System.Net;
using System.Net.Mail;
using BaseProject.Modules.Mail.Wrappers.Interfaces;

namespace BaseProject.Modules.Mail.Wrappers
{
    public class SmtpWrapper : ISmtpClient
    {
        public SmtpClient Client { get; set; }

        public SmtpWrapper()
        {
            // Use Port 25 if 587 is blocked
            Client = new SmtpClient
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("hello@bordell.io", "l0rd0fthewh0res!"),
                Port = 587,
                Host = "outlook.office365.com",
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true
            };
        }

        public void Send(MailMessage message)
        {
            Client.Send(message);
        }
    }
}