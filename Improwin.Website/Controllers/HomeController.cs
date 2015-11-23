using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Improwin.Website.Models;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Improwin.Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Helper hl)
        {

            StringBuilder strMailBody = new StringBuilder();
            strMailBody.Append("<html xmlns='http://www.w3.org/1999/xhtml'>");
            strMailBody.Append("<head>");
            strMailBody.Append("</head>");
            strMailBody.Append("<body>");

            #region MailBody
            strMailBody.Append("<div><div><label><b>Name :</b></label>");
            strMailBody.Append(hl.name);
            strMailBody.Append("</div><div><label><b>Email:</b></label>");
            strMailBody.Append(hl.email);
            strMailBody.Append("</div><div><label><b>Phone :</b></label>");
            strMailBody.Append(hl.ph);
            strMailBody.Append("</div><div><label><b>Company Name :</b></label>");
            strMailBody.Append(hl.company);
            strMailBody.Append("</div><div><label><b>Subject:</b></label>");
            strMailBody.Append(hl.subject);
            strMailBody.Append("</div><div><label><b>Message:</b></label>");
            strMailBody.Append(hl.msg);
            strMailBody.Append("</div></div>");
            strMailBody.Append("</body>");
            strMailBody.Append("</html>");

            EmailHandler _emailHanlder = new EmailHandler();
            _emailHanlder._subject = hl.subject;
            _emailHanlder._sender = "info@improwinsolutions.com";
            _emailHanlder._displayName = "Improwin Sender";
            _emailHanlder._mailbody = strMailBody;
            _emailHanlder._recipients = new string[] {"info@improwinsolutions.com"};

            _emailHanlder.Send();

            #endregion MailBody


            //Main Table End
            



            return this.Json(new { msg = "success" });
            

        }

        }
}