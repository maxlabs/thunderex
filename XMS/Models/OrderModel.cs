using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XMS.Models
{
    public class OrderModel
    {
        private long id;
        private string title;
        private string paId;
        private bool isAgent;

        public OrderModel() { }
        public OrderModel(long id, string title, string paId, bool isAgent)
        {
            this.id = id;
            this.title = title;
            this.paId = paId;
            this.isAgent = isAgent;                
        }

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string PaId
        {
            get
            {
                return paId;
            }

            set
            {
                paId = value;
            }
        }

        public bool IsAgent
        {
            get
            {
                return isAgent;
            }

            set
            {
                isAgent = value;
            }
        }
    }
}