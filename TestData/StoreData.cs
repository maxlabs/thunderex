using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thunder.ApplicationCore.Entities;
using Thunder.ApplicationCore.Entities.PricePro;
using Thunder.Infrastructure.Data;

namespace Thunder.TestData.PricePro
{
    public class StoreData
    {
        public static void Init(XmsDbContext context)
        {
            //context.Database.ExecuteSqlCommand("ALTER TABLE [dbo].[Store] DROP CONSTRAINT [FK_dbo.Store_dbo.Store_ParentId]");
            List<TbStore> list = new List<TbStore>();
            int lastId = 1;
            list.AddRange(InitType1(lastId, out lastId));
            list.ForEach(tmp => context.Stores.Add(tmp));
            context.SaveChanges();
        }

        public static List<TbStore> InitType1(int id, out int lastId)
        {
            lastId = id;
            List<TbStore> list = new List<TbStore>();
            list.Add(new TbStore() { Id = lastId++, DepartId = 1 });
            list.Add(new TbStore() { Id = lastId++, DepartId = 1 });
            list.Add(new TbStore() { Id = lastId++, DepartId = 2 });
            list.Add(new TbStore() { Id = lastId++, DepartId = 3 });
            list.Add(new TbStore() { Id = lastId++, DepartId = 4 });
            list.Add(new TbStore() { Id = lastId++, DepartId = 5 });
            list.Add(new TbStore() { Id = lastId++, DepartId = 6 });
            list.Add(new TbStore() { Id = lastId++, DepartId = 7 });
            list.Add(new TbStore() { Id = lastId++, DepartId = 1 });
            return list;
        }
    }
}