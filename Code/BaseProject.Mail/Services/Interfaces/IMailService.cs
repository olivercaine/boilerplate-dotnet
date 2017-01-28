using System.Net.Mail;

namespace BaseProject.Modules.Mail.Services.Interfaces
{
    public interface IMailService 
    {
        void SubmitMailMessage(MailMessage mailMessage);
    }
}