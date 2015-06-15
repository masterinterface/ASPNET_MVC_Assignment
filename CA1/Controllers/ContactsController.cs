using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//this controller needs to access the Contacts and Sms models 
using CA1.Models;

namespace CA1.Controllers
{
    //this is the 2nd controller (as per assignment specifications) and deals with displaying pre-recorded contact's details
    public class ContactsController : Controller
    {

    // method to return a view that outputs a table (list) of each contact's fname, lname, and phone numbers
    // this method passes a Contacts object (people) to the strongly bound view 'DisplayContacts'
    public ActionResult DisplayContacts()
        {
            //instantiate the Contacts class 
            Contacts contactsTest = new Contacts();
            //so that we can then use the Person list within
            List<Person> people = new List<Person>();
            people = contactsTest.contacts;
            //and pass it to the strongly bound view (bound to an IENumerable of Person)
            return View(people);
        }
    
        // method to receive 2 parameters from the 'DisplayContacts' view
        // this method creates a new Sms object, assigns it the parameters given from View, and passes it to the 'SendSms' view
        public ActionResult ToContact(String destArea, String destNum)
        {
            //instantiate a new Sms obejct
            Sms sms = new Sms();
            //so that we can assign it our two input parameters
            destArea = sms.destArea;
            destNum = sms.destNum;
            //and send it on to the strongly bound 'SendSms' View (bound to the Sms model)
            return View("SendSms", sms);
        }

    }
}
