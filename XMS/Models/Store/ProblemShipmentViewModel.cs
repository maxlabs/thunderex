using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thunder.XMS.Models
{
    public class ProblemShipmentViewModel
    {
        public ProblemShipmentViewModel()
        {

        }

        public ProblemShipmentViewModel(int id, int orderId, string serviceId, string opState, string respState, string customer, string channel, string create, DateTime createTime)
        {
            this.Id = id;
            this.OrderId = orderId;
            this.ServiceId = serviceId;
            this.OpState = opState;
            this.ResponseState = respState;
            this.Customer = customer;
            this.Channel = channel;
            this.Creater = create;
            this.CreateTime = DateTime.Now;
        }
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// 服务商单号
        /// </summary>
        public string ServiceId { get; set; }
        /// <summary>
        /// 操作状态
        /// </summary>
        public string OpState { get; set; }
        /// <summary>
        /// 问题状态
        /// </summary>
        public string ResponseState { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string Customer { get; set; }
        /// <summary>
        /// 销售产品
        /// </summary>
        public string Channel { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Creater { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}