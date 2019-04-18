using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunder.ApplicationCore.Entities;
using Thunder.ApplicationCore.Entities.PricePro;
using Thunder.Infrastructure.Data;

namespace Thunder.TestData.PricePro
{
    public class IncidentalPriceData
    {
        public static void Init(XmsDbContext context)
        {
            List<IncidentalPrice> list = new List<IncidentalPrice>()
            {
                new IncidentalPrice() {Id = 1, GoodsType = GoodsType.Bag, UnitCode = "KG", UnitNumber = 1.0, UnitValue = 2.5000, Name = "Z2", BeginTime = DateTime.Now, EndTime = DateTime.Now},
                new IncidentalPrice() {Id = 2, GoodsType = GoodsType.Bag, UnitCode = "BS", UnitNumber = 1.0, UnitValue = 10.0000, Name = "Z3", BeginTime = DateTime.Now, EndTime = DateTime.Now },
                new IncidentalPrice() {Id = 3, GoodsType = GoodsType.Bag, UnitCode = "BS", UnitNumber = 1.0, UnitValue = 0.0000, Name = "Z4", BeginTime = DateTime.Now, EndTime = DateTime.Now },
                new IncidentalPrice() {Id = 4, GoodsType = GoodsType.Bag, UnitCode = "BS", UnitNumber = 1.0, UnitValue = 0.0000, Name = "Z5", BeginTime = DateTime.Now, EndTime = DateTime.Now },
                new IncidentalPrice() {Id = 5, GoodsType = GoodsType.Bag, UnitCode = "BS", UnitNumber = 1.0, UnitValue = 0.0000, Name = "Z6", BeginTime = DateTime.Now, EndTime = DateTime.Now },
                new IncidentalPrice() {Id = 6, GoodsType = GoodsType.Bag, UnitCode = "BS", UnitNumber = 1.0, UnitValue = 10.0000, Name = "Z7", BeginTime = DateTime.Now, EndTime = DateTime.Now },
                new IncidentalPrice() {Id = 7, GoodsType = GoodsType.Bag, UnitCode = "BS", UnitNumber = 1.0, UnitValue = 20.0000, Name = "Z8", BeginTime = DateTime.Now, EndTime = DateTime.Now },
                new IncidentalPrice() {Id = 8, GoodsType = GoodsType.Bag, UnitCode = "BS", UnitNumber = 1.0, UnitValue = 50.0000, Name = "P2", BeginTime = DateTime.Now, EndTime = DateTime.Now },
                new IncidentalPrice() {Id = 9, GoodsType = GoodsType.Bag, UnitCode = "DP", UnitNumber = 1.0, UnitValue = 0.0300, Name = "E4", BeginTime = DateTime.Now, EndTime = DateTime.Now },
                new IncidentalPrice() {Id = 10, GoodsType = GoodsType.Bag,UnitCode = "DP", UnitNumber = 1.0, UnitValue = 0.0300, Name = "H7", BeginTime = DateTime.Now, EndTime = DateTime.Now },
                new IncidentalPrice() {Id = 11, GoodsType = GoodsType.Bag,UnitCode = "BS", UnitNumber = 1.0, UnitValue = 0.0000, Name = "Y6", BeginTime = DateTime.Now, EndTime = DateTime.Now },
                new IncidentalPrice() {Id = 12, GoodsType = GoodsType.Bag, UnitCode = "BS", UnitNumber = 1.0, UnitValue = 0.0000, Name = "Y7", BeginTime = DateTime.Now, EndTime = DateTime.Now },
                new IncidentalPrice() {Id = 13, GoodsType = GoodsType.Bag, UnitCode = "BS", UnitNumber = 1.0, UnitValue = 0.0000, Name = "Y5", BeginTime = DateTime.Now, EndTime = DateTime.Now },
            };
            list.ForEach(tmp => context.IncidentalPrices.Add(tmp));
            context.SaveChanges();
        }
    }
}
