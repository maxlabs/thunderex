using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Thunder.ApplicationCore.Entities
{
    /// <summary>
    /// 门店
    /// </summary>
    public class Store : BaseEntity
    {
        #region 数据库字段        
        /// <summary>
        /// 部门编号
        /// </summary>
        public int DepartId { get; set; }        
        /// <summary>
        /// 信用额度
        /// </summary>
        public double BarterCredit { get; set; }
        #endregion

        #region 实体数据
        /// <summary>
        /// 上级门店
        /// </summary>
        [ForeignKey("DepartId")]
        public virtual Department Department { get; set; }
        #endregion
    }
}