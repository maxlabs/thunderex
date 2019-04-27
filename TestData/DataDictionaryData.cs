using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunder.ApplicationCore.Entities;
using Thunder.Infrastructure.Data;

namespace Thunder.TestData
{
    public class DataDictionaryData
    {
        public static void Init(XmsDbContext context)
        {
            context.Database.ExecuteSqlCommand("ALTER TABLE [dbo].[TbDataDictionary] DROP CONSTRAINT [FK_dbo.TbDataDictionary_dbo.TbDataDictionary_ParentId]");
            List<TbDataDictionary> list = new List<TbDataDictionary>();
            int lastId = 1;
            list.AddRange(InitType1(lastId, out lastId));
            list.ForEach(tmp => context.DataDictionarys.Add(tmp));
            context.SaveChanges();
        }

        public static List<TbDataDictionary> InitType1(int id, out int lastId)
        {
            lastId = id;
            List<TbDataDictionary> list = new List<TbDataDictionary>();
            list.Add(new TbDataDictionary() { Id = lastId++, ParentId = 0, Code = "CodeA", Name = "类型A" });
            list.Add(new TbDataDictionary() { Id = lastId++, ParentId = id, Code = "CodeB", Name = "类型B" });
            list.Add(new TbDataDictionary() { Id = lastId++, ParentId = id, Code = "CodeC", Name = "类型C" });
            list.Add(new TbDataDictionary() { Id = lastId++, ParentId = id, Code = "CodeD", Name = "类型D" });
            list.Add(new TbDataDictionary() { Id = lastId++, ParentId = id, Code = "CodeE", Name = "类型E" });
            list.Add(new TbDataDictionary() { Id = lastId++, ParentId = id, Code = "CodeF", Name = "类型F" });
            list.Add(new TbDataDictionary() { Id = lastId++, ParentId = id, Code = "CodeG", Name = "类型G" });
            list.Add(new TbDataDictionary() { Id = lastId++, ParentId = id, Code = "CodeH", Name = "类型H" });
            list.Add(new TbDataDictionary() { Id = lastId++, ParentId = id, Code = "CodeI", Name = "类型I" });
            return list;
        }
    }
}
