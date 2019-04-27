using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thunder.XMS.Models
{
    public class MaterielViewModel
    {
        public int Id { get; set; }
        public string Store { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Count { get; set; }
        public string Status { get; set; }

    }
}