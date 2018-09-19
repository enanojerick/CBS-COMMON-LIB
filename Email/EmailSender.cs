using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using CBS.Common.Interface;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Mime;
using System.Web;
using System;
using Microsoft.AspNetCore.StaticFiles;


namespace CBS.Common.Services.Email
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings settings;

        public EmailSender(EmailSettings settings)
        {
            this.settings = settings;
        }

        //public string SendEmail(EmailDto email, ListDictionary replacements)
        //{
        //    try
        //    {
        //        MailDefinition md = new MailDefinition();
        //        md.From = email.EmailSender;
        //        md.IsBodyHtml = true;
        //        md.Subject = email.EmailSubject;

        //        MailMessage mail = md.CreateMailMessage(email.EmailRecipient, replacements, email.EmailBody, new System.Web.UI.Control());
        //        string inputHtmlContent = mail.Body;

        //        string outputHtmlContent = string.Empty;
        //        var myResources = new List<LinkedResource>();

        //        if ((!string.IsNullOrEmpty(inputHtmlContent)))
        //        {

        //            var doc = new HtmlDocument();
        //            doc.LoadHtml(inputHtmlContent);
        //            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//img");
        //            if (nodes != null)
        //            {
        //                foreach (HtmlNode node in nodes)
        //                {
        //                    if (node.Attributes.Contains("src"))
        //                    {
        //                        string contentType;
        //                        string data = node.Attributes["src"].Value;
        //                        string imgPath = System.Web.HttpContext.Current.Server.MapPath(data);
        //                        new FileExtensionContentTypeProvider().TryGetContentType(imgPath, out contentType);
        //                        var image = new LinkedResource(imgPath);
        //                        image.ContentId = Guid.NewGuid().ToString();
        //                        image.ContentType = new ContentType(contentType);
        //                        myResources.Add(image);
        //                        node.Attributes["src"].Value = string.Format("cid:{0}", image.ContentId);
        //                        outputHtmlContent = doc.DocumentNode.OuterHtml;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                outputHtmlContent = inputHtmlContent;
        //            }
        //            AlternateView av2 = AlternateView.CreateAlternateViewFromString(outputHtmlContent, null, MediaTypeNames.Text.Html);
        //            foreach (LinkedResource linkedResource in myResources)
        //            {
        //                av2.LinkedResources.Add(linkedResource);
        //            }

        //            mail.AlternateViews.Add(av2);
        //        }


        //        SmtpClient smtpServer = new SmtpClient(settings.Host);
        //        smtpServer.Credentials = new System.Net.NetworkCredential(settings.UserName, settings.Password);
        //        smtpServer.Port = settings.Port;
        //        smtpServer.Send(mail);

        //        return "Sending Successful";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.InnerException.Message.ToString();
        //    }

        //}

        public string SendEmail(EmailDto emaildto)
        {
            try
            {
                MailMessage mail = new MailMessage(emaildto.EmailSender, emaildto.EmailRecipient);
                mail.IsBodyHtml = true;
                SmtpClient smtpServer = new SmtpClient(settings.Host);
                smtpServer.Credentials = new System.Net.NetworkCredential(settings.UserName, settings.Password);
                smtpServer.Port = settings.Port;
                smtpServer.EnableSsl = true;
                mail.Subject = emaildto.EmailSubject;
                mail.Body = emaildto.EmailBody;
                smtpServer.Send(mail);

                return "Sending Successful";
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message.ToString();
            }
            

        }
    }
}
