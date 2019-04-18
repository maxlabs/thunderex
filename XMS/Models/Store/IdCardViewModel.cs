using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thunder.XMS.Models
{
    public class IdCardViewModel
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string Customer { get; set; }
        public string CustomerCard { get; set; }
        public string Receiver { get; set; }
        public string ReceiveCard { get; set; }
    }
}