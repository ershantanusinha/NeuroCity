using System;
using System.Collections.Generic;
using System.Web;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Net;

public partial class Appointnment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("theneurocityhospital@gmail.com");
            mail.To.Add("theneurocityhospital@gmail.com");
            // to send mail....code is
            // mail.To.Add(TextBox2.Text);
            mail.IsBodyHtml = true;
            mail.Subject = "form";
            mail.Body = "<br><br>hi the folowing new Appointment you have...<br>" + "<b>Name:</b>" + TextBox1.Text + "<br><b>Phone Number:</b>" + TextBox2.Text + "<br><b>Appointment Date:</b>" + TextBox3.Text + "<br><b>Subject:" + TextBox4.Text + "<br><b>Department:"+ListBox1.SelectedItem + "<br><b>other:" + TextBox5.Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential(txtEmail.Text = "theneurocityhospital@gmail.com".ToString(), txtPassword.Text = "shantanusinha".ToString());
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mail);
            string url_1 = ("http://sms.theneurocity.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=f2d7f8cad8f03745aa10c8b375c9e0&message=Dear " + TextBox1.Text + ",Thank You For your Booking you will get a confirmation SMS and call from The NeuroCity Hospital very soon &senderId=NUROCT&routeId=1&mobileNos= " + TextBox2.Text + "&smsContentType=english");
           // Response.Redirect("http://sms.theneurocity.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=f2d7f8cad8f03745aa10c8b375c9e0&message=Daer" + TextBox1.Text + ",Thank You For your Booking you will get a confirmation SMS and call from The NeuroCity Hospital very soon &senderId=NUROCT&routeId=1&mobileNos= " + TextBox2.Text + "&smsContentType=english");
            string url_2 = ("http://sms.theneurocity.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=f2d7f8cad8f03745aa10c8b375c9e0&message=Inquery '" + "Name:" + TextBox1.Text + "Phone Number:" + TextBox2.Text + "Appointment Date:" + TextBox3.Text + "Subject:" + TextBox4.Text + "Department:" + ListBox1.SelectedItem + "other:" + TextBox5.Text + "&senderId=NUROCT&routeId=1&mobileNos=7080109056" + "&smsContentType=english");
        string Responce_1 = GetResponse_1(url_1);
        string Responce_2 = GetResponse_2(url_2);
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        Label1.Text = "Thank You For your Booking you will get a confirmation SMS and call from Big Cab very soon".ToString();
       Response.Write("<script>alert('thanks for the Appoinment BOOKING ..WE WILL contact you soon')</script>");
    }
    public static string GetResponse_1(string url_1)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url_1);
        request.MaximumAutomaticRedirections = 4;
        request.Credentials = CredentialCache.DefaultCredentials;
        try
        {
            HttpWebResponse response_1 = (HttpWebResponse)request.GetResponse();
            Stream receiveStream = response_1.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string Response_1 = readStream.ReadToEnd();
            response_1.Close();
            readStream.Close();
            return Response_1;
        }
        catch
        {
            return "";
        }

    }
    public static string GetResponse_2(string url_2)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url_2);
        request.MaximumAutomaticRedirections = 4;
        request.Credentials = CredentialCache.DefaultCredentials;
        try
        {
            HttpWebResponse response_2 = (HttpWebResponse)request.GetResponse();
            Stream receiveStream = response_2.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string Response_2 = readStream.ReadToEnd();
            response_2.Close();
            readStream.Close();
            return Response_2;
        }
        catch
        {
            return "";
        }

    }   
        
         }
    
