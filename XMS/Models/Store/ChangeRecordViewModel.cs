using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thunder.XMS.Models
{
    public class ChangeRecordViewModel
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string Content { get; set; }
        public string OpUser { get; set; }
        public DateTime OpTime { get; set; }
    }
}