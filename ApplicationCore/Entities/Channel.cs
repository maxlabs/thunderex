using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thunder.ApplicationCore.Entities
{
    /// <summary>
    /// 渠道
    /// </summary>
    public class Channel : BaseEntity
    {
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 渠道名称
        /// </summary>
        public string Name { get; set; }        
        /// <summary>
        /// 应收款
        /// </summary>
        public double ShouldPay { get; set; }
        /// <summary>
        /// 应付款
        /// </summary>
        public double ShouldCollection { get; set; }
    }
}