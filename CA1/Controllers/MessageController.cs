using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA1.Models;

namespace CA1.Controllers
{
    // this is the default controller that handles message sending 
    public class MessageController : Controller
    {
        //[GET}
        // this is the default ActionResult --> returns a View for sending a new message
        public ActionResult SendSms()
        {
            return View();
        }

        //this ActionResult receives an Sms 'object' back from the form in the 'SendSms' View
        [HttpPost]
        public ActionResult SendSms(Sms sms)
        {
            //this is back end validation ( the front end validation can be found within View) --> both are bound to the model 
            //handles event where any model errors have been added to ModelState (eg a bool instead of string)
            if (ModelState.IsValid)
            {
                // instantiate a new Contacts object to search the List within
                Contacts testContacts = new Contacts();
                // and assign output to a string 
                string search = testContacts.search(sms.destArea, sms.destNum);

                //then incase a match was found, we need to pass the fName and lNames on to the View to be returned  
                // as this is a RedirectToAction we need to use a TempData
                TempData["searchoutput"] = search;
                
                //we also need to pass on the SmsText input param to the View to be returned 
                // as this is a RedirectToAction we need to use a TempData
                TempData["message"] = sms.smsText;
                
                //when the search() method finds no match within the contacts list
                if (search == "nomatch")
                    return RedirectToAction("Error");
                //search() found a match --> we then return a Succes view with a confirmation message.
                else
                {
                    // this method logs all messages sent to the Output Debug console in VS
                    CA1.SentMessageLog.outputToDebugConsole(sms.smsText);
                    return RedirectToAction("Succes");             
                }
            }
            //if the Modelstate is not valid --> this ActionResult will pass its fields (including non-valid ones) back to the view. User can then modify.
            return View(sms);
        }


        public ActionResult Succes()
        {
            ViewBag.Message = TempData["searchoutput"].ToString();
            ViewBag.SmsMessage = TempData["message"].ToString();

            return View();
        }


        public ActionResult Error()
        {
            ViewBag.Message = TempData["searchoutput"].ToString();
            ViewBag.SmsMessage = TempData["message"].ToString();

            return View();
        }

    }
}
