using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Thunder.Infrastructure.Data;
using Thunder.TestData.PricePro;

namespace Thunder.TestData
{
    public class XmsInitializer : DropCreateDatabaseIfModelChanges<XmsDbContext>
    {
        protected override void Seed(XmsDbContext context)
        {
            DataDictionaryData.Init(context);
            DepartmentData.Init(context);
            DistributionCenterData.Init(context);
            StoreData.Init(context);
            CurrencyRateData.Init(context);
            IncidentalPriceData.Init(context);
            ChannelData.Init(context);  
        }
    }
}