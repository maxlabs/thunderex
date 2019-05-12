using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thunder.XMS.Models.Store
{
    public class ApplicationMaterialViewModel
    {
        public ApplicationMaterialViewModel()
        {

        }

        public ApplicationMaterialViewModel(int id, string senderName, string uploadSender, string uploadSenderIdCard, string receiveName, string uploadReceiver, string uploadReceiveIdCard)
        {
            this.Id = id;
            this.SenderName = senderName;
            this.UploadSenderName = uploadSender;
            this.UploadSenderIdCard = uploadSenderIdCard;
            this.ReceiveName = receiveName;
            this.UploadReceiveName = uploadReceiver;
            this.UploadReceiverIdCard = uploadReceiveIdCard;
        }
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string UploadSenderName { get; set; }
        public string UploadSenderIdCard { get; set; }
        public string ReceiveName { get; set; }
        public string UploadReceiveName { get; set; }
        public string UploadReceiverIdCard { get; set; }
    }
}