using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thunder.XMS.Models
{
    public class BillViewModel
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public string Receiver { get; set; }
        public string RecvMobile { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public double Fee { get; set; }
        public string State { get; set; }
    }
}