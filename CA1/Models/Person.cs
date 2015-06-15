using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CA1.Models
{
    public class Person
    {
        //this is the output for the table header 
        [Display(Name = "First Name")]
        public string fName { get; set; }

        //this is the output for the table header 
        [Display(Name = "Last Name")]
        public string lName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string destArea { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string destNum { get; set; }

        //constuctor for possible additions to Person list (within the Contacts class)
        public Person(string fName, string lName, string destArea, string destNum)
        {
            this.fName = fName; this.lName = lName;
            this.destArea = destArea; this.destNum = destNum;
        }

    }
}