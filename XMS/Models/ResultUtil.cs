using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XMS.Models
{
    public class ResultUtil
    {
        public static dynamic success()
        {
            return vo(CoreConst.SUCCESS_CODE, null, null);
        }

        public static dynamic success(string msg)
        {
            return vo(CoreConst.SUCCESS_CODE, msg, null);
        }

        public static dynamic success(string msg, object data)
        {
            return vo(CoreConst.SUCCESS_CODE, msg, data);
        }

        public static dynamic error()
        {
            return vo(CoreConst.FAIL_CODE, null, null);
        }

        public static dynamic error(string msg)
        {
            return vo(CoreConst.FAIL_CODE, msg, null);
        }

        public static dynamic error(string msg, object data)
        {
            return vo(CoreConst.FAIL_CODE, msg, data);
        }

        public static dynamic vo(int status, string message, object data)
        {
            return new { status = status, msg = message, data = data };
        }
    }

    public class CoreConst
    {
        public static readonly int SUCCESS_CODE = 200;
        public static readonly int FAIL_CODE = 500;
    }
    
    public class ResponseVo<T>
    {
        private int status;
        private String msg;
        private T data;

        public int getStatus()
        {
            return status;
        }

        public void setStatus(int status)
        {
            this.status = status;
        }

        public String getMsg()
        {
            return msg;
        }

        public void setMsg(String msg)
        {
            this.msg = msg;
        }

        public T getData()
        {
            return data;
        }

        public void setData(T data)
        {
            this.data = data;
        }

        public ResponseVo(int status, String msg)
        {
            this.status = status;
            this.msg = msg;
        }

        public ResponseVo(int status, String msg, T data)
        {
            this.status = status;
            this.msg = msg;
            this.data = data;
        }

    }
}