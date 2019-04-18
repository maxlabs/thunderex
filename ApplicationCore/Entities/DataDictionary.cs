using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Thunder.ApplicationCore.Entities
{
    /// <summary>
    /// 数据字典
    /// </summary>
    public class DataDictionary : BaseEntity
    {
        /// <summary>
        /// 父类编号
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// 父类编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 父类名称
        /// </summary>
        public string Name { get; set; }

        [ForeignKey("ParentId")]
        public virtual DataDictionary Parent { get; set; }
        [ForeignKey("ParentId")]
        public virtual ICollection<DataDictionary> Children { get; set; }
    }
}