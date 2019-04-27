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
    public static class BooleanSelectColumnExtensions
    {
        public static MvcHtmlString DataGridBooleanSelectColumn(this HtmlHelper htmlHelper, string title, string field, string trueValue, string falseValue)
        {
            return DataGridBooleanSelectColumn(htmlHelper, title, field, trueValue, falseValue, 0);
        }

        public static MvcHtmlString DataGridBooleanSelectColumn(this HtmlHelper htmlHelper, string title, string field, string trueValue, string falseValue, int width)
        {
            return DataGridBooleanSelectColumn(htmlHelper, title, field, trueValue, falseValue, width, false, true);
        }

        public static MvcHtmlString DataGridBooleanSelectColumn(this HtmlHelper htmlHelper, string title, string field, string trueValue, string falseValue, int width, bool sortable, bool visible)
        {
            return DataGridBooleanSelectColumn(htmlHelper, title, field, trueValue, falseValue, width, sortable, visible, null);
        }

        public static MvcHtmlString DataGridBooleanSelectColumn(this HtmlHelper htmlHelper, string title, string field, string trueValue, string falseValue, int width, bool sortable, bool visible, string style)
        {
            return DataGridBooleanSelectColumn(htmlHelper, title, field, trueValue, falseValue, width, sortable, visible, style, true);
        }

        private static MvcHtmlString DataGridBooleanSelectColumn(this HtmlHelper htmlHelper, string title, string field, string trueValue, string falseValue, int width, bool sortable, bool visible, string style, bool editable)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("                        editable:{");
            builder.AppendLine("                            type: 'select',");
            builder.AppendLine($"                            title: '{title}',");
            builder.AppendLine("                            source: function() {");
            builder.AppendLine("                                var result = [];");
            builder.AppendLine($"                                result.push({{value: false, text: '{falseValue}'}});");
            builder.AppendLine($"                                result.push({{value: true, text: '{trueValue}'}});");            
            builder.AppendLine("                                return result;");
            builder.AppendLine("                            }");
            builder.AppendLine("                        }");
            return htmlHelper.DataGridColumn(title, field, width, sortable, visible, style, builder.ToString());
        }
    }
}