using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Thunder.ApplicationCore.Entities;
using Thunder.Infrastructure.Data;

namespace Thunder.TestData
{
    /// <summary>
    /// 集散中心
    /// </summary>
    public class DepartmentData
    {
        public static void Init(XmsDbContext context)
        {
            //context.Database.ExecuteSqlCommand("ALTER TABLE [dbo].[Department] DROP CONSTRAINT [FK_dbo.Department_dbo.Department_ParentId]");
            List<Department> list = new List<Department>();
            int lastId = 1;
            list.AddRange(InitType1(lastId, out lastId));
            list.ForEach(tmp => context.Departments.Add(tmp));
            context.SaveChanges();
        }

        public static List<Department> InitType1(int id, out int lastId)
        {
            lastId = id;
            List<Department> list = new List<Department>();
            list.Add(new Department() { Id = lastId++, ParentId = 0, Code = "CodeA", Name = "类型A" });
            list.Add(new Department() { Id = lastId++, ParentId = id, Code = "CodeB", Name = "类型B" });
            list.Add(new Department() { Id = lastId++, ParentId = id, Code = "CodeC", Name = "类型C" });
            list.Add(new Department() { Id = lastId++, ParentId = id, Code = "CodeD", Name = "类型D" });
            list.Add(new Department() { Id = lastId++, ParentId = id, Code = "CodeE", Name = "类型E" });
            list.Add(new Department() { Id = lastId++, ParentId = id, Code = "CodeF", Name = "类型F" });
            list.Add(new Department() { Id = lastId++, ParentId = id, Code = "CodeG", Name = "类型G" });
            list.Add(new Department() { Id = lastId++, ParentId = id, Code = "CodeH", Name = "类型H" });
            list.Add(new Department() { Id = lastId++, ParentId = id, Code = "CodeI", Name = "类型I" });
            return list;
        }
    }
}