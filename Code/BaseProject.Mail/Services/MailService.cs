using System;
using System.IO;
using System.Net.Mail;
using BaseProject.Modules.Mail.Services.Interfaces;
using BaseProject.Modules.Mail.Settings;
using BaseProject.Modules.Mail.Wrappers.Interfaces;

namespace BaseProject.Modules.Mail.Services
{
    public class MailService : IMailService
    {
        private readonly ISmtpClient smtpWrapper;

        public MailService(ISmtpClient smtpWrapper)
        {
            this.smtpWrapper = smtpWrapper;
        }

        public void SubmitMailMessage(MailMessage mailMessage)
        {
            try
            {
                smtpWrapper.Send(mailMessage);
            }
            catch (Exception ex)
            {
                string pickupDirectory = MailSettings.Settings.MailPickupDirectory;
                if (!Directory.Exists(pickupDirectory))
                    Directory.CreateDirectory(pickupDirectory);

                smtpWrapper.Client.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                smtpWrapper.Client.EnableSsl = false;
                smtpWrapper.Client.PickupDirectoryLocation = MailSettings.Settings.MailPickupDirectory;
                smtpWrapper.Send(mailMessage);
            }
        }
    }
}