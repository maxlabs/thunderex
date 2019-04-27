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
    public class DistributionCenterData
    {
        public static void Init(XmsDbContext context)
        {
            //context.Database.ExecuteSqlCommand("ALTER TABLE [dbo].[DistributionCenter] DROP CONSTRAINT [FK_dbo.DistributionCenter_dbo.DistributionCenter_ParentId]");
            List<TbDistributionCenter> list = new List<TbDistributionCenter>();
            int lastId = 1;
            list.AddRange(InitType1(lastId, out lastId));
            list.ForEach(tmp => context.DistributionCenters.Add(tmp));
            context.SaveChanges();
        }

        public static List<TbDistributionCenter> InitType1(int id, out int lastId)
        {
            lastId = id;
            List<TbDistributionCenter> list = new List<TbDistributionCenter>();
            list.Add(new TbDistributionCenter() { Id = lastId++, DepartId = 1 });
            list.Add(new TbDistributionCenter() { Id = lastId++, DepartId = 2 });
            list.Add(new TbDistributionCenter() { Id = lastId++, DepartId = 3 });
            list.Add(new TbDistributionCenter() { Id = lastId++, DepartId = 4 });
            list.Add(new TbDistributionCenter() { Id = lastId++, DepartId = 5 });
            list.Add(new TbDistributionCenter() { Id = lastId++, DepartId = 6 });
            list.Add(new TbDistributionCenter() { Id = lastId++, DepartId = 7 });
            list.Add(new TbDistributionCenter() { Id = lastId++, DepartId = 1 });
            list.Add(new TbDistributionCenter() { Id = lastId++, DepartId = 2 });
            return list;
        }
    }
}