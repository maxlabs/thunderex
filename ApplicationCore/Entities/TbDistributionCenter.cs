using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Thunder.ApplicationCore.Entities
{
    /// <summary>
    /// 集散中心
    /// </summary>
    public class TbDistributionCenter : BaseEntity
    {
        #region 数据库字段
        /// <summary>
        /// 父节点编号
        /// </summary>
        public int DepartId { get; set; }
        /// <summary>
        /// 信用额度
        /// </summary>
        public double BarterCredit { get; set; }
        #endregion

        #region 实体属性
        /// <summary>
        /// 父节点
        /// </summary>
        [ForeignKey("DepartId")]
        public virtual TbDepartment Department { get; set; }
        #endregion
    }
}