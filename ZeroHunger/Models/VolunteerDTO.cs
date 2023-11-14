using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.Models
{
    public class VolunteerDTO
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please provide your First Name")]
        public string firstname { get; set; }
        [Required(ErrorMessage = "Please provide your Last Name")]
        public string lastname { get; set; }
        [Required(ErrorMessage = "Please provide your Email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Please provide your Gender")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Please provide your Phone Number")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Please provide your Position")]
        public string position { get; set; }
        [Required(ErrorMessage = "Please provide your Address")]
        public string address { get; set; }
        [Required(ErrorMessage = "Please provide your Age")]
        public string age { get; set; }
        [Required(ErrorMessage = "Please provide your Password")]
        public string password { get; set; }
    }
}