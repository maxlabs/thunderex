using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunder.ApplicationCore.Entities
{
    public class Department : BaseEntity
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 部门编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 部门类型
        /// </summary>
        public DepartmentType DepartType { get; set; }
        /// <summary>
        /// 父部门编号
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// 父部门
        /// </summary>
        
        //public virtual Department Parent { get; set; }
        //[ForeignKey("ParentId")]
        //public virtual ICollection<Department> Children { get; set; }
    }

    public enum DepartmentType
    {
        /// <summary>
        /// 门店
        /// </summary>
        Store,
        /// <summary>
        /// 集散中心
        /// </summary>
        DistributionCenter,
        /// <summary>
        /// 仓库中心
        /// </summary>
        Storage,
        /// <summary>
        /// 运输
        /// </summary>
        Transport
    }
}
