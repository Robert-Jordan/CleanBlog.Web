using CleanBlog.Core.ViewModels;
using System.Net.Mail;

namespace CleanBlog.Core.Services
{
    public class SmtpService : ISmtpService
    {
        public SmtpService()
        {

        }
        public bool SendEmail(ContactViewModel model)
        {
            try
            {
                var message = new MailMessage();
                var client = new SmtpClient();
                var toAddress = "to@test.com";
                var fromAddress = "from@test.com";
                message.Subject = $"Enquiry from {model.Name} - {model.Email}";
                message.Body = model.Message;
                message.To.Add(new MailAddress(toAddress, toAddress));
                message.From = new MailAddress(fromAddress, fromAddress);
                client.Send(message);
                return true;
            }
            catch (SmtpException ex)
            {
                //_logger.Error("Error sending contact form.", ex);
                return false;
            }
        }
    }
}
