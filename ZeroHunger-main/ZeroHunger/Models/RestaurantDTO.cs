using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.Models
{
    public class RestaurantDTO
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please provide the Restaurant Name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please provide your First Name")]
        public string address { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string type { get; set; }
        public string password { get; set; }
    }
}