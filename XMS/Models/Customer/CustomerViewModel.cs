using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thunder.XMS.Models
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {

        }

        public CustomerViewModel(int id, string name, string sex, string mobile, string email, double credit)
        {
            this.Id = id;
            this.Name = name;
            this.Sex = sex;
            this.Mobile = mobile;
            this.Email = email;
            this.Credit = credit;
        }
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string Email { get; set; }
        public double Credit { get; set; }
    }
}