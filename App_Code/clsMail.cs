using System;
using System.Data;
using System.Web;
using System.Configuration;
using System.Net.Mail;
using System.Text;

/// <summary>
/// Summary description for clsMail
/// </summary>
public class clsMail
{
    #region Private Variables
    private string _ClientEmail,_Subject,_MailBody;
    #endregion

    public clsMail()
	{
		//
		// TODO: Add constructor logic here
		//
    }

    #region Properties
    public string ClientEmail
    {
        get
        {
            return _ClientEmail;
        }
        set
        {
            _ClientEmail = value;
        }
    }
    public string Subject
    {
        get
        {
            return _Subject;
        }
        set
        {
            _Subject = value;
        }
    }
    public string Mailbody
    {
        get
        {
            return _MailBody;
        }
        set
        {
            _MailBody = value;
        }
    }
    #endregion

    #region Methods

    /// <summary>
    /// Sending Email with Invoice
    /// </summary>
    public void SendEmail()
    {
        try
        {
//            EmailMessage objMsg = new EmailMessage("mail.massoftind.com");
//            EmailMessage objMsg = new EmailMessage(ConfigurationSettings.AppSettings["SmtpAddress"].ToString());
//            objMsg.FromAddress = Convert.ToString(ConfigurationSettings.AppSettings["Admin_EmailJob"]);
//            objMsg.To = ClientEmail;
//            objMsg.Cc = ConfigurationSettings.AppSettings["Admin_Email"].ToString();
//            objMsg.Bcc = ConfigurationSettings.AppSettings["Admin_MailCCID"].ToString();
//            objMsg.BodyFormat = MailFormat.Html;
//            objMsg.Priority = MailPriority.High;
//            objMsg.Subject = Subject;
//            objMsg.Body = Mailbody;

//            #region template
//            //objMsg.EmbedImage("bg", Server.MapPath("../images/bg.gif"));

//            //msg.EmbedImage("mail_01", Server.MapPath("../images/mail_01.gif"));

//            //msg.EmbedImage("mail_02", Server.MapPath("../images/mail_02.gif"));

//            //msg.EmbedImage("mail_03", Server.MapPath("../images/mail_03.gif"));

//            //msg.EmbedImage("mail_04", Server.MapPath("../images/mail_04.gif"));

//            //msg.EmbedImage("mail_05", Server.MapPath("../images/mail_05.gif"));

//            //msg.EmbedImage("mail_06", Server.MapPath("../images/mail_06.gif"));

//            //msg.EmbedImage("mail_07", Server.MapPath("../images/mail_07.gif"));
//#endregion

            //            objMsg.Send();

        }
        catch (Exception ex)
        {
            throw ex;
        }   
        
    }

    public void WebMailSendWithAttachment(string strTo, string strSubject,
        string strMailBody, Boolean boolHasAttachment , string strFilename)
    {
        MailMessage objMessage = new MailMessage();
        objMessage.From = new MailAddress(ConfigurationManager.AppSettings["AdminEmailAddress"].ToString()); 
        
        if (strTo != string.Empty || strTo != null || strTo != "")
        {
            objMessage.To.Add(strTo);
        }

        Boolean boolDoCC = false;
        boolDoCC = Convert.ToBoolean(ConfigurationManager.AppSettings["DoCC"].ToString());

        if (boolDoCC == true)
        {
            if (ConfigurationManager.AppSettings["CcAddress"].ToString()!="")
            {
                objMessage.CC.Add(ConfigurationManager.AppSettings["CcAddress"].ToString());  
            }
          
        }
        objMessage.Priority = MailPriority.High;
        objMessage.IsBodyHtml = true;
        objMessage.Subject = strSubject;
        objMessage.Body = strMailBody;
        if (boolHasAttachment == true)
        {
            objMessage.Attachments.Add(new Attachment(strFilename));
        }

        SmtpClient objSmtpServer = new SmtpClient(ConfigurationManager.AppSettings["SmtpServer"].ToString());

        try
        {
            objSmtpServer.Send(objMessage);
            objMessage.Attachments.Dispose();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    #endregion

    public int WebMailSend(string strTo, string strSubject,StringBuilder strMailBody)
    {
        string smptClient = ConfigurationManager.AppSettings["SmtpServer"].ToString();
       // strTo = "info@improwinsolutions.com";
        MailMessage objMessage = new MailMessage();
        objMessage.From = new MailAddress(ConfigurationManager.AppSettings["AdminEmailAddress"].ToString());
        objMessage.To.Add(ConfigurationManager.AppSettings["ToContactUsEmailAddress"].ToString());
        objMessage.CC.Add(ConfigurationManager.AppSettings["CcContactUsEmailAddress"].ToString());

        if (strTo != string.Empty || strTo != null || strTo != "")
        {
            objMessage.To.Add(strTo);
        }
       
        objMessage.Priority = MailPriority.High;
        objMessage.IsBodyHtml = true;
        objMessage.Subject = strSubject;
        objMessage.Body = strMailBody.ToString();
       


       // SmtpClient objSmtpServer = new SmtpClient("smptClient");

        SmtpClient smtpClient = new SmtpClient("improwinsolutions.com", 587);
        smtpClient.EnableSsl = false;
        //smtpClient.

        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new System.Net.NetworkCredential("info@improwinsolutions.com", "Fightforwin#2015");

        
    

        try
        {
            smtpClient.Send(objMessage);
            return 1;
           
        }
        catch (Exception ex)
        {
            throw ex;
            return -1;
        }
    }
    
}
