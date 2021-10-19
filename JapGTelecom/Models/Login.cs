using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JapGTelecom.Models
{
    public class Login
    {
        public int id { get; set; }


        [Display(Name = "Enter Name")]
        public string UName { get; set; }


        [Display(Name = "Enter Password")]
        public string UPassword { get; set; }

    }
}
