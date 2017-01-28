using System.Net.Mail;

namespace BaseProject.Modules.Mail.Wrappers.Interfaces
{
    public interface ISmtpClient
    {
        SmtpClient Client { get; set; }
        void Send(MailMessage message);
    }
}