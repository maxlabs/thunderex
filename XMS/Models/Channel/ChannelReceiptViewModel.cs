using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thunder.XMS.Models.Channel
{
    public class ChannelReceiptViewModel
    {
        public ChannelReceiptViewModel()
        {

        }

        public ChannelReceiptViewModel(int id, double weight, double country1, double country2, double country3)
        {
            this.Id = id;
            this.Weight = weight;
            this.Country1 = country1;
            this.Country2 = country2;
            this.Country3 = country3;
        }

        public int Id { get; set; }
        public double Weight { get; set; }
        public double Country1 { get; set; }
        public double Country2 { get; set; }
        public double Country3 { get; set; }        
    }
}