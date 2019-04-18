using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thunder.XMS.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string Customer { get; set; }
        
        public string Mobile { get; set; }
        public string IdCard { get; set; }
        public double Fee { get; set; }
        
    }
}