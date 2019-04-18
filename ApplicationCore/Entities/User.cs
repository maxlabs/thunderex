using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunder.ApplicationCore.Entities
{
    /// <summary>
    /// 雇员
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public int DepartId { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public UserRole Role { get; set; }

        [ForeignKey("DepartId")]
        public virtual Department Department { get; set; }
    }

    [Flags]
    public enum UserRole
    {
        Type1 = 1,
        Type2 = 2,
    }
}
