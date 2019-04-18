using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thunder.ApplicationCore.Entities;

namespace Thunder.XMS.Models
{
    public class DepartmentViewModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 父编号
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string DepartType { get; set; }
        public double Credit { get; set; }
    }
}