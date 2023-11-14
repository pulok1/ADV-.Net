using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZeroHunger.Models
{
    public class PickupDTO
    {
        public int id { get; set; }
        public string restaurentRequsted { get; set; }
        public string status { get; set; }
        public int quantity { get; set; }
        public string lastPickupAllowed { get; set; }
        public string diliveryAddress { get; set; }
    }
}