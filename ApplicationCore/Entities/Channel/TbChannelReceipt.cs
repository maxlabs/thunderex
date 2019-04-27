using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunder.ApplicationCore.Entities.Channel
{
    public class TbChannelReceipt : BaseEntity
    {
        public int ChannelId { get; set; }
        public double Weight { get; set; }
        public int CountryId { get; set; }
        public double Price { get; set; }
    }
}
