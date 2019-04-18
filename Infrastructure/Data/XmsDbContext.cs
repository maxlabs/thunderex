using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Thunder.ApplicationCore.Entities;
using Thunder.ApplicationCore.Entities.PricePro;

namespace Thunder.Infrastructure.Data
{
    public class XmsDbContext : DbContext
    {
        public XmsDbContext() : base("XmsDbContext") {
        }
        /// <summary>
        /// 数据字典
        /// </summary>
        public DbSet<DataDictionary> DataDictionarys { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        public DbSet<Department> Departments { get; set; }
        /// <summary>
        /// 渠道
        /// </summary>
        public DbSet<Channel> Channels { get; set; }
        /// <summary>
        /// 门店
        /// </summary>
        public DbSet<Store> Stores { get; set; }
        /// <summary>
        /// 集散中心
        /// </summary>
        public DbSet<DistributionCenter> DistributionCenters { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// 客户
        /// </summary>
        public DbSet<Customer> Customers { get; set; }
        /// <summary>
        /// 物料
        /// </summary>
        public DbSet<Materiel> Materiels { get; set; }
        /// <summary>
        /// 物料申请/审批
        /// </summary>
        public DbSet<MaterielOrder> MaterielOrders { get; set; }
        /// <summary>
        /// 汇率
        /// </summary>
        public DbSet<CurrencyRate> CurrencyRates { get; set; }
        /// <summary>
        /// 杂费
        /// </summary>
        public DbSet<IncidentalPrice> IncidentalPrices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}