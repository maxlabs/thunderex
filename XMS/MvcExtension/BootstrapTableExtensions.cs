using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc.Html
{
    public static class BootstrapTableExtensions
    {
        public static MvcHtmlString DataGridCheckBoxColumn(this HtmlHelper htmlHelper, string title, string field, int width, bool sortable, bool visible, string style, string editable = null)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");
            builder.AppendLine($"title: '{title}',");
            builder.AppendLine($"field: '{field}',");
            if (width > 0)
            {
                builder.AppendLine($"width: {width},");
            }
            builder.AppendLine($"sortable: {sortable},");
            builder.AppendLine($"visible: {visible},");
            if (!string.IsNullOrWhiteSpace(style))
            {
                builder.AppendLine(style);
            }
            if (!string.IsNullOrWhiteSpace(editable))
            {
                builder.AppendLine(style);
            }
            builder.AppendLine("}");
            return new MvcHtmlString(builder.ToString());
        }


        public static MvcHtmlString DataGridColumn(this HtmlHelper htmlHelper, string title, string field, int width, bool sortable, bool visible, string style, string editable = null)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("                    {");
            builder.AppendLine($"                        title: '{title}',");
            builder.AppendLine($"                        field: '{field}',");
            if (width > 0)
            {
                builder.AppendLine($"                        width: {width},");
            }
            builder.AppendLine($"                        sortable: {sortable.ToString().ToLower()},");
            builder.AppendLine($"                        visible: {visible.ToString().ToLower()},");
            if (!string.IsNullOrWhiteSpace(style))
            {
                builder.AppendLine($"                        {style}");
            }
            if(!string.IsNullOrWhiteSpace(editable))
            {
                builder.AppendLine(editable);
            }            
            builder.AppendLine("                    }");
            return new MvcHtmlString(builder.ToString());
        }
    }
}