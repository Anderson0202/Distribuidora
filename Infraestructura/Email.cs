using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class Email
    {
        private MailMessage email;
        private SmtpClient smtp;
        public Email()
        {
            smtp = new SmtpClient();
        }
        

        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("andersonallfair@gmail.com",
             "ilovedsuddenattack2.0");
        }

        private void ConfigurarEmail(Cliente cliente)
        {
            
            email = new MailMessage(); 
            email.To.Add(cliente.Email);
            email.From = new MailAddress("andersonallfair@gmail.com");
            email.Subject = $"Anderson OM Registro de Usuario {cliente.Nombre}"
                + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.Body = $"<b>Sr {cliente.Email}</b> <br " +
                $" > se ha realizado su registro Sartisfactoriamente";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }

        

        public string EnviarEmail(Cliente cliente)
        {

            try
            {
                ConfigurarSmt();
                ConfigurarEmail(cliente);
                smtp.Send(email);
                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {

                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }

    }
}
