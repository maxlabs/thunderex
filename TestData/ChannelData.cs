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
            List<TbChannel> list = new List<TbChannel>()
            {
                new TbChannel() {Id = 1, Name = "渠道A" },
                new TbChannel() {Id = 2, Name = "渠道B" },
                new TbChannel() {Id = 3, Name = "渠道C" },
                new TbChannel() {Id = 4, Name = "渠道D" },
                new TbChannel() {Id = 5, Name = "渠道E" },
                new TbChannel() {Id = 6, Name = "渠道F" },
                new TbChannel() {Id = 7, Name = "渠道G" },
            };
            list.ForEach(tmp => context.Channels.Add(tmp));
            context.SaveChanges();
        }
    }
}