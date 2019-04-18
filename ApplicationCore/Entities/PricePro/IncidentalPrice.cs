using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Thunder.ApplicationCore.Entities.PricePro
{
    public class IncidentalPrice : BaseEntity
    {
        /// <summary>
        /// 费用名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 货物类型
        /// </summary>
        public GoodsType GoodsType { get; set; }
        /// <summary>
        /// 计费单位
        /// </summary>
        public string UnitCode { get; set; }
        /// <summary>
        /// 单位数量
        /// </summary>
        public double UnitNumber { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public double UnitValue { get; set; }
        /// <summary>
        /// 基值
        /// </summary>
        public double BaseFee { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        public DateTime BeginTime { get; set; }

        /// <summary>
        /// 终止时间
        /// </summary>
        public DateTime EndTime { get; set; }
    }

    [Flags]
    public enum GoodsType
    {
        /// <summary>
        /// 包裹
        /// </summary>
        Package = 1,
        /// <summary>
        /// 袋子
        /// </summary>
        Bag = 2,
        /// <summary>
        /// 文件
        /// </summary>
        File = 3
    }
}