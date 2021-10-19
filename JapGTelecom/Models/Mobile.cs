using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JapGTelecom.Models
{
    public class Mobile
    {
        public int id { get; set; }


        [Display(Name = "Company")]
        public string Company { get; set; }


        [Display(Name = "Model No")]
        public string ModelNo { get; set; }

        [Display(Name = "Feature")]
        public string Feature { get; set; }

        [Display(Name = "Price")]
        public string Price { get; set; }



    }
}
