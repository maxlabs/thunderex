using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using Thunder.ApplicationCore.Entities;

namespace System.Web.Mvc.Html
{
    public static class OperationColumnExtensions
    {
        public static MvcHtmlString DataGridOperationColumn(this HtmlHelper htmlHelper, string title, int width, string button, string url, string style)
        {
            List<ButtonInfo> list = new List<ButtonInfo>();
            list.Add(new ButtonInfo(button, url, style));
            return DataGridOperationColumn(htmlHelper, title, list, width);
        }

        public static MvcHtmlString DataGridOperationColumn(this HtmlHelper htmlHelper, string title, int width, string button1, string url1, string style1, string button2, string url2, string style2)
        {
            List<ButtonInfo> list = new List<ButtonInfo>();
            list.Add(new ButtonInfo(button1, url1, style1));
            list.Add(new ButtonInfo(button2, url2, style2));
            return DataGridOperationColumn(htmlHelper, title, list, width);
        }

        public static MvcHtmlString DataGridOperationColumn(this HtmlHelper htmlHelper, string title, int width, string button1, string url1, string style1, string button2, string url2, string style2, string button3, string url3, string style3)
        {
            List<ButtonInfo> list = new List<ButtonInfo>();
            list.Add(new ButtonInfo(button1, url1, style1));
            list.Add(new ButtonInfo(button2, url2, style2));
            list.Add(new ButtonInfo(button3, url3, style3));
            return DataGridOperationColumn(htmlHelper, title, list, width);
        }

        public static MvcHtmlString DataGridOperationColumn(this HtmlHelper htmlHelper, string title, int width, string button1, string url1, string style1, string button2, string url2, string style2, string button3, string url3, string style3, string button4, string url4, string style4)
        {
            List<ButtonInfo> list = new List<ButtonInfo>();
            list.Add(new ButtonInfo(button1, url1, style1));
            list.Add(new ButtonInfo(button2, url2, style2));
            list.Add(new ButtonInfo(button3, url3, style3));
            list.Add(new ButtonInfo(button4, url4, style4));
            return DataGridOperationColumn(htmlHelper, title, list, width);
        }

        private static MvcHtmlString DataGridOperationColumn(this HtmlHelper htmlHelper, string title, IEnumerable<ButtonInfo> buttonList, int width)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("                    {");
            builder.AppendLine($"                        title: '{title}',");
            builder.AppendLine($"                        field: 'operate',");            
            builder.AppendLine($"                        align: 'center',");
            builder.AppendLine($"                        valign: 'middle',");
            if (width > 0)
            {
                builder.AppendLine($"                        width: {width},");
            }
            builder.AppendLine("                        formatter: function (value, row, index) {");
            builder.AppendLine("                            var e = '<div class=\"tableBody\">'");
            int length = 12 / buttonList.Count();
            foreach(ButtonInfo info in buttonList)
            {
                builder.AppendLine($"                            e += '<div class=\"col-sm-{length}\"><button type=\"button\" class=\"{info.Style}\" onclick=\"location.href=\\'{info.Url}\\'\">{info.Name}</button></div>'; ");
            }
            builder.AppendLine("                            return e;");
            builder.AppendLine("                        }");
            builder.AppendLine("                    }");
            return new MvcHtmlString(builder.ToString());
        }
        

        public class ButtonInfo
        {
            public ButtonInfo()
            {

            }

            public ButtonInfo(string name, string url, string style)
            {
                this.Name = name;
                this.Url = url;
                this.Style = style;
            }
            public string Name { get; set; }
            public string Url { get; set; }
            public string Style { get; set; }
        }
    }
}