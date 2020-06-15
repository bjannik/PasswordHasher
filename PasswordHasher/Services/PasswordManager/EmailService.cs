using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace PasswordManager.Services.PasswordManager
{
    class EmailService
    {

        public static void SendMail()
        {
            Console.WriteLine("The email will be sent");
            MailAddress to = new MailAddress("j.bartels@journaway.com");
            MailAddress from = new MailAddress("verify@bartels.technology");

            MailMessage message = new MailMessage(from, to);
            message.Subject = "Verify your login";
            message.Body = "Hurra hurra";

            SmtpClient client = new SmtpClient("smtp.ionos.de", 587)
            {
                Credentials = new NetworkCredential("verify@bartels.technology", "password"),
                EnableSsl = true
            };

            try
            {
                client.Send(message);
                Console.WriteLine("the email has been sent");
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("the email was not sent");
            }

        }

    }
}
