﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thunder.ApplicationCore.Entities;

namespace Thunder.XMS.Models
{
    public class ChannelViewModel
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

        public CarryMethod CarryMethod { get; set; }
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
}