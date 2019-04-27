using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thunder.ApplicationCore.Entities.PricePro;
using Thunder.Infrastructure.Data;

namespace Thunder.TestData.PricePro
{
    public class CurrencyRateData
    {
        public static void Init(XmsDbContext context)
        {
            List<TbCurrencyRate> list = new List<TbCurrencyRate>()
            {
                new TbCurrencyRate() {Id = 1, IsEnabled = true, BeginDate = DateTime.Now, EndDate = DateTime.Now, Code = "GBP", Name = "英镑", Rate = 8.9000, CreateTime = DateTime.Now, ModifyTime = DateTime.Now },
                new TbCurrencyRate() {Id = 2, IsEnabled = true, BeginDate = DateTime.Now, EndDate = DateTime.Now, Code = "HKD", Name = "港币", Rate = 0.8000, CreateTime = DateTime.Now, ModifyTime = DateTime.Now },
                new TbCurrencyRate() {Id = 3, IsEnabled = true, BeginDate = DateTime.Now, EndDate = DateTime.Now, Code = "RMB", Name = "人民币", Rate = 1.0000, CreateTime = DateTime.Now, ModifyTime = DateTime.Now },
                new TbCurrencyRate() {Id = 4, IsEnabled = true, BeginDate = DateTime.Now, EndDate = DateTime.Now, Code = "RUB", Name = "俄罗斯卢布", Rate = 0.1000, CreateTime = DateTime.Now, ModifyTime = DateTime.Now},
                new TbCurrencyRate() {Id = 5, IsEnabled = true, BeginDate = DateTime.Now, EndDate = DateTime.Now, Code = "SGD", Name = "新加坡元", Rate = 4.8000, CreateTime = DateTime.Now, ModifyTime = DateTime.Now },
                new TbCurrencyRate() {Id = 6, IsEnabled = true, BeginDate = DateTime.Now, EndDate = DateTime.Now, Code = "USD", Name = "美元", Rate = 6.5000, CreateTime = DateTime.Now, ModifyTime = DateTime.Now },
            };
            list.ForEach(tmp => context.CurrencyRates.Add(tmp));
            context.SaveChanges();
        }
    }
}