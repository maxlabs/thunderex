using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thunder.XMS.Models
{
    public class StoreFinancialViewModel
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsPay { get; set; }
        public double Fee { get; set; }
        public string Source { get; set; }
    }
}