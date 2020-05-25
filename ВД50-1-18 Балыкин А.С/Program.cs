using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ВД50_1_18_Балыкин_А.С
{
    class Program
    {
        static void Main(string[] args)
        {
            MailAddress from = new MailAddress("address@gmail.com", "NAME");
            MailAddress to = new MailAddress("address@yandex.ru");
            MailMessage objectMail = new MailMessage(from, to);
            objectMail.Subject = "Текст";
            objectMail.Body = "<h2>Письмо-текст работы smpt-клиента</h2>";
            objectMail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smpt.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("address@gmail.com", "mypassword");
            smtp.EnableSsl = true;
            smtp.Send(objectMail);
            _ = Console.Read();
        }
    }
}
