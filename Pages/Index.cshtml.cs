using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesPerosnalWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public ContactForm ContactForm { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        #region SendEmailDetails

        public async Task<IActionResult> OnPostAsync()
        {
            using (var smtp = new SmtpClient())
            {

                smtp.UseDefaultCredentials = false;
                var credential = new NetworkCredential
                {

                    UserName = "",
                    Password = ""

                };

                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true; //Not running on TSL.

                var message = new MailMessage();
                message.To.Add("stephenp3123@gmail.com");
                message.From = new MailAddress(ContactForm.EmailAddress.ToString());
                message.Subject = "New Contact";
                message.Body = string.Format(ContactForm.FormMessage);
                message.IsBodyHtml = true;
                try
                {
                    if (message != null)
                    {
                        await smtp.SendMailAsync(message);
                    }
                }
                catch (SmtpFailedRecipientsException ex)
                {
                    for (int i = 0; i < ex.InnerExceptions.Length; i++)
                    {
                        SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                        if (status == SmtpStatusCode.MailboxBusy ||
                            status == SmtpStatusCode.MailboxUnavailable)
                        {
                            Console.WriteLine("Delivery failed - retrying in 5 seconds.");
                            System.Threading.Thread.Sleep(5000);
                            smtp.Send(message);
                        }
                        else
                        {
                            Console.WriteLine("Failed to deliver message to {0}",
                            ex.InnerExceptions[i].FailedRecipient);
                        }
                    }
                }
                catch (System.Exception ex)
                {

                    throw ex;


                }
                finally
                {

                    smtp.Dispose();
                }

            }
            return RedirectToPage("Index", "Success");

        }

        #endregion

    }


}
