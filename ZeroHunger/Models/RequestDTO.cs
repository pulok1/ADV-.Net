using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZeroHunger.Models
{
    public class RequestDTO
    {
        public int id { get; set; }
        public string restaurentName { get; set; }
        public string requestDate { get; set; }
        public string status { get; set; }
        public int quantity { get; set; }
    }
}