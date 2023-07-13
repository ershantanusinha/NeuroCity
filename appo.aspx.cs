using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class appo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Btn_SendMail_Click(object sender, EventArgs e)
    {
        System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
        mail.To.Add("bigcabvns@gmail.com");
        mail.From = new MailAddress("er.shantanu.sinha@gmail.com", "inquiry from website", System.Text.Encoding.UTF8);
        mail.Subject = txtSubject.Text.ToString();
        mail.SubjectEncoding = System.Text.Encoding.UTF8;
        mail.Body = txtBody.Text.ToString();
        mail.BodyEncoding = System.Text.Encoding.UTF8;
        mail.IsBodyHtml = true;
        mail.Priority = MailPriority.High;
        SmtpClient client = new SmtpClient();
        client.Credentials = new System.Net.NetworkCredential("er.shantanu.sinha@gmail.com", "chotababu");
        client.Port = 587;
        client.Host = "smtp.gmail.com";
        client.EnableSsl = true;
        try
        {
            client.Send(mail);
            
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
            string errorMessage = string.Empty;
            while (ex2 != null)
            {
                errorMessage += ex2.ToString();
                ex2 = ex2.InnerException;
            }
            Label1.Text = "this is invalid input";
            
        }
    }
}