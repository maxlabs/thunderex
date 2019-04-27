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
    public static class EnumSelectColumnExtensions
    {
        #region Enum
        public static MvcHtmlString DataGridEnumSelectColumn(this HtmlHelper htmlHelper, string title, string field, Type type)
        {
            return DataGridEnumSelectColumn(htmlHelper, title, field, type, 0);
        }

        public static MvcHtmlString DataGridEnumSelectColumn(this HtmlHelper htmlHelper, string title, string field, Type type,int width)
        {
            return DataGridEnumSelectColumn(htmlHelper, title, field, type, width, false, true);
        }

        public static MvcHtmlString DataGridEnumSelectColumn(this HtmlHelper htmlHelper, string title, string field, Type type, int width, bool sortable, bool visible)
        {
            return DataGridEnumSelectColumn(htmlHelper, title, field, type, width, sortable, visible, null);
        }

        public static MvcHtmlString DataGridEnumSelectColumn(this HtmlHelper htmlHelper, string title, string field, Type type, int width, bool sortable, bool visible, string style)
        {
            return DataGridEnumSelectColumn(htmlHelper, title, field, type, width, sortable, visible, style, true);
        }

        private static MvcHtmlString DataGridEnumSelectColumn(this HtmlHelper htmlHelper, string title, string field, Type type, int width, bool sortable, bool visible, string style, bool editable)
        {
            if (type.BaseType != typeof(Enum))
            {
                throw new Exception($"{type.FullName}不是Enum类型");
            }
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("                        editable:{");
            builder.AppendLine("                            type: 'select',");
            builder.AppendLine($"                            title: '{title}',");
            builder.AppendLine("                            source: function() {");
            builder.AppendLine("                                var result = [];");
            FieldInfo[] fields = type.GetFields();
            foreach (FieldInfo info in fields)
            {

                DisplayAttribute attribute = info.GetCustomAttribute<DisplayAttribute>();
                if (attribute != null)
                {
                    builder.AppendLine($"                                result.push({{value: {info.GetRawConstantValue()}, text: '{attribute.Name}'}});");
                }
            }

            builder.AppendLine("                                return result;");
            builder.AppendLine("                            }");
            builder.AppendLine("                        }");

            return htmlHelper.DataGridColumn(title, field, width, sortable, visible, style, builder.ToString());
        }
        #endregion
    }
}