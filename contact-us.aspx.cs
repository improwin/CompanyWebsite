using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class contact_us : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Sending_E_mail();
    }
    private void Sending_E_mail()
    {
        clsMail objMail = new clsMail();
        int returnValue=0;

        StringBuilder strMailBody = new StringBuilder();
       
        strMailBody.Append("<html xmlns='http://www.w3.org/1999/xhtml'>");
        strMailBody.Append("<head>");
        //strMailBody.Append("<link href='" + ConfigurationManager.AppSettings["AdminRootPath"] + "min.css' rel='stylesheet' type='text/css' />");
        strMailBody.Append("</head>");
        strMailBody.Append("<body>");

        #region MailBody
        strMailBody.Append("<div><div><label><b>Name :</b></label>");
        strMailBody.Append(this.name.Text);
        strMailBody.Append("</div><div><label><b>Email:</b></label>");
        strMailBody.Append(this.txtEmail.Text);
        strMailBody.Append("</div><div><label><b>Phone :</b></label>");
        strMailBody.Append(this.txtPhone.Text);
        strMailBody.Append("</div><div><label><b>Company Name :</b></label>");
        strMailBody.Append(this.txtCompanyName.Text);
        strMailBody.Append("</div><div><label><b>Subject:</b></label>");
        strMailBody.Append(this.txtSubject.Text);
        strMailBody.Append("</div><div><label><b>Message:</b></label>");
        strMailBody.Append(this.txtMessage.Text);
        strMailBody.Append("</div></div>");

        
     
        #endregion MailBody


        //Main Table End
        strMailBody.Append("</body>");
        strMailBody.Append("</html>");

        string strMailSubject = this.txtSubject.Text;
        //string strMailSubject = "";

         string strClientMail = string.Empty;


            string tomail = string.Empty;
        
            tomail = "ripanbasu@gmail.com";
        returnValue=objMail.WebMailSend(tomail, strMailSubject, strMailBody);
       // returnValue = 1;
        if (returnValue == 1)
        {
            lbl_sendmessage.Visible = true;
            lbl_sendmessage.Text = "Message Sent Successfully";
        }
        else
        {
            lbl_sendmessage.Visible = true;
            lbl_sendmessage.Text = "Message Sent Failyure";


        }
        this.name.Text = "";
        this.txtEmail.Text = "";
        this.txtPhone.Text = "";
        this.txtCompanyName.Text = "";
        this.txtSubject.Text = "";
        this.txtMessage.Text = "";
       
    }
}

