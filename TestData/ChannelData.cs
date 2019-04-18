using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thunder.ApplicationCore.Entities;
using Thunder.ApplicationCore.Entities.PricePro;
using Thunder.Infrastructure.Data;

namespace Thunder.TestData.PricePro
{
    public class ChannelData
    {
        public static void Init(XmsDbContext context)
        {
            List<Channel> list = new List<Channel>()
            {
                new Channel() {Id = 1, Name = "渠道A" },
                new Channel() {Id = 2, Name = "渠道B" },
                new Channel() {Id = 3, Name = "渠道C" },
                new Channel() {Id = 4, Name = "渠道D" },
                new Channel() {Id = 5, Name = "渠道E" },
                new Channel() {Id = 6, Name = "渠道F" },
                new Channel() {Id = 7, Name = "渠道G" },
            };
            list.ForEach(tmp => context.Channels.Add(tmp));
            context.SaveChanges();
        }
    }
}