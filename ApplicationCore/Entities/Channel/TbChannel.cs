using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Thunder.ApplicationCore.Entities
{
    /// <summary>
    /// 渠道
    /// </summary>
    public class TbChannel : BaseEntity
    {
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 渠道名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 进位方式
        /// </summary>
   
        public  CarryMethod CarryMethod { get; set; }
        /// <summary>
        /// 重量限制
        /// </summary>
        public double WeightLimit { get; set; }
        /// <summary>
        /// 长
        /// </summary>
        public double LengthLimit { get; set; }
        /// <summary>
        /// 宽
        /// </summary>
        public double WidthLimit { get; set; }
        /// <summary>
        /// 高
        /// </summary>
        public double HeightLimit { get; set; }
        /// <summary>
        /// 是否需要身份证信息
        /// </summary>
        public bool NeedIdCard { get; set; }
        /// <summary>
        /// 中英文限制
        /// </summary>
        public LanguageType Language { get; set; }
    }

    public enum LanguageType
    {
        /// <summary>
        /// 中文
        /// </summary>
        [Display(Name ="中文")]
        Chinese = 0,
        [Display(Name = "英文")]
        English = 1,
        [Display(Name = "中英文")]
        Both = 2
    }

    //[Flags]
    public enum CarryMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "进位取整")]
        CarryInteger = 0,
        [Display(Name = "未知")]
        CarryHalf = 1
    }
}