using System.Net.Mail;
using BaseProject.Modules.Mail.Services;
using BaseProject.Modules.Mail.Wrappers.Interfaces;
using NUnit.Framework;
using Rhino.Mocks;

namespace BaseProject.Modules.Mail.Tests
{
    [TestFixture]
    public class When_submitting_a_mail_message
    {
        private static MailMessage CreateMailMessage()
        {
            var to = new MailAddress("receiver@ukstudentdigs.com");
            var from = new MailAddress("sender@ukstudentdigs.com", "Sender name");
            var mailMessage = new MailMessage(from, to)
            {
                Subject = "Mail subject",
                Body = "Body content",
                IsBodyHtml = true
            };
            mailMessage.Bcc.Add("olliecaine@gmail.com");
            //mailMessage.ReplyToList = new MailAddress(from.Address, from.DisplayName);
            return mailMessage;
        }

        [Test]
        public void Should_pass_mail_message_to_smtp_wrapper()
        {
            var mockSmtpClient = MockRepository.GenerateStub<ISmtpClient>();
            var service = new MailService(mockSmtpClient);
            MailMessage mailMessage = CreateMailMessage();

            service.SubmitMailMessage(mailMessage);

            mockSmtpClient.AssertWasCalled(sc => sc.Send(Arg<MailMessage>.Is.Anything));
        }
    }
}