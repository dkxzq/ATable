using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATable.Data
{
    /// <summary>
    /// getData 的摘要说明
    /// </summary>
    public class getData : IHttpHandler
    {
        protected static List<OrderDetail> details = new List<OrderDetail>();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}