using Cliff_Single_Portfolio_Page.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Cliff_Single_Portfolio_Page.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //GET: Email
        public ActionResult Contact()
        {
            Email model = new Email();
            return View(model);
        }


        //POST: Email
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(Email model)
        {
            try
            {
                EmailService ems = new EmailService();
                IdentityMessage msg = new IdentityMessage();
                //Email vis = new Email();

                
                msg.Body = model.FromName + Environment.NewLine + model.Body + Environment.NewLine + "Contact's email " + model.FromEmail;



                msg.Destination = "cgk3008.ck@gmail.com";
                msg.Subject = "Portfolio message from " + model.FromName;

                await ems.SendMailAsync(msg);
            }
            catch (Exception ex)
            {
                await Task.FromResult(0);
            }
            return RedirectToAction("Index", "Home");
        }



    }
}
