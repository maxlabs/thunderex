using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunder.ApplicationCore.Entities
{
    /// <summary>
    /// 物料申请
    /// </summary>
    public class TbMaterielOrder : BaseEntity
    {
        /// <summary>
        /// 物料编号
        /// </summary>
        public int MaterId { get; set; }
        /// <summary>
        /// 物料数量
        /// </summary>
        public int Count { get; set; }
        
        /// <summary>
        /// 申请部门
        /// </summary>
        public int ReqDepartId { get; set; }
        /// <summary>
        /// 申请用户编号
        /// </summary>
        public int ReqUserId { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime ReqTime { get; set; }

        /// <summary>
        /// 申请部门
        /// </summary>
        public int RespDepartId { get; set; }
        /// <summary>
        /// 审批用户编号
        /// </summary>
        public int RespUserId { get; set; }
        /// <summary>
        /// 审批时间
        /// </summary>
        public DateTime RespTime { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string Reason { get; set; }


        [ForeignKey("MaterId")]
        public virtual TbMateriel Materiel { get; set; }
      
        //[ForeignKey("ReqUserId")]
        //public virtual User ReqUser { get; set; }

        //[ForeignKey("RespUserId")]
        //public virtual User RespUser { get; set; }       

    }

    [Flags]
    public enum MaterielOrderStatus
    {
        Request = 0x01,
        Allow = 0x02,
        Deny = 0x03
    }
}
