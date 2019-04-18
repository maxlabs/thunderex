using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thunder.XMS.Models
{
    public class CustomerBillViewModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// 账单
        /// </summary>
        public double Fee { get; set; }

        public DateTime CreateDate { get; set; }

        public string State { get; set; }
    }
}