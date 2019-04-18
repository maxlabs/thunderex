using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XMS.Models
{
    public class CustomerModel
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Company { get; set; }
        public string Telphone { get; set; }
        public string Mobilephone { get; set; }
        public string Address { get; set; }
        public DateTime CreateTime { get; set; }

        public CustomerModel() { }

        public CustomerModel(long id, string username, string password, string company, string telphone, string mobilephone, string address)
        {
            this.Id = id;
            this.UserName = username;
            this.Password = password;
            this.Company = company;
            this.Telphone = telphone;
            this.Mobilephone = mobilephone;
            this.Address = address;
        }
    }
}