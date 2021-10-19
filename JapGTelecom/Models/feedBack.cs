using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JapGTelecom.Models
{
    public class feedBack
    {
        public int id { get; set; }


        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Message")]
        public String Message { get; set; }

        

    }
}
