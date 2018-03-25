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
             //Post Assign a ticket thru email notification
    [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Email()
        {
            try
            {
                EmailService ems = new EmailService();
                IdentityMessage msg = new IdentityMessage();
                //User user = db.Users.Find(model.AssignedToUserId);
                //User user = db.Users.Find(model.AssignedToUserId);

                msg.Body = "New Ticket Assignment." + Environment.NewLine + "Please click the following link to view the details " + "<a href=\"" + callbackUrl + "\">NEW TICKET</a>";

                msg.Destination = user.Email;
                msg.Subject = "Assigned Ticket";
                await ems.SendMailAsync(msg);
            }
            catch (Exception ex)
            {
                await Task.FromResult(0);
            }
            return RedirectToAction("Index");
        }




            return View();
    }
}

   




}
