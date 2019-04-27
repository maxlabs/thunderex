using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunder.ApplicationCore.Entities
{
    /// <summary>
    /// 物料
    /// </summary>
    public class TbMateriel : BaseEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
    }
}
