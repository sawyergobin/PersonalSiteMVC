using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalSiteMVC.UI.MVC.Models
{
    public class ContactViewModel
    {


        [Required(ErrorMessage = "* Name Is Required")]
        [Display(Name = "Your Name")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Please Enter A Valid Email")]
        [Required(ErrorMessage = "* Email Is Required")]
        [Display(Name = "Your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="* Subject Is Required")]
        public string Subject { get; set; }
        [UIHint("MultilineText")]
        [Required(ErrorMessage = "* A Message is required")]
        public string Message { get; set; }
    }
}
