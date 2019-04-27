using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Thunder.ApplicationCore.Entities.PricePro
{
    /// <summary>
    /// 汇率
    /// </summary>
    public class TbCurrencyRate : BaseEntity
    {
        public string Code { get; set; }
        /// <summary>
        /// 币种
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 汇率
        /// </summary>
        public double Rate { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        public DateTime EndDate { get; set; }       

        /// <summary>
        /// 创建人
        /// </summary>
        public int CreateUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ModifyUserId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyTime { get; set; }     
        
         
    }

    
}