using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CA1.Models
{
    public class Sms
    {
        //this is outputted next to the textarea
        [Display(Name="Area Code")]
        //validation for user inputs
        [Required(ErrorMessage = "Area code must not be blank!")] 
        [DataType(DataType.PhoneNumber)]
        //validation for user inputs
        [StringLength(3, MinimumLength=3, ErrorMessage ="3 digits please")]
        public string destArea {get; set;}

        //this is outputted next to the textarea
        [Display(Name="Number")]
        [Required(ErrorMessage = "Number must not be blank!")] 
        [DataType(DataType.PhoneNumber)]
        [StringLength(7, MinimumLength=7, ErrorMessage ="7 digits please")]
        public string destNum {get; set;}

        //this is outputted next to the textarea
        [Display(Name = "Message")]
        [Required(ErrorMessage = "Message must not be blank")]
        [MinLength(1, ErrorMessage = "Enter at least one character!")]
        [MaxLength(140, ErrorMessage = "Sms too long! 140 characters maximum.")]
        public string smsText { get; set; }

    }
}
