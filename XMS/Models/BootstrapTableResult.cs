using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XMS.Models
{
    [Serializable]
    public class BootstrapTableResult
    {
        private long total;
        private object rows;

        public long getTotal()
        {
            return total;
        }

        public void setTotal(long total)
        {
            this.total = total;
        }

        public object getRows()
        {
            return rows;
        }

        public void setRows(object rows)
        {
            this.rows = rows;
        }
    }
}