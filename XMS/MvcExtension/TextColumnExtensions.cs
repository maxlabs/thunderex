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
    public static class TextColumnExtensions
    {

        public static MvcHtmlString DataGridInputColumn(this HtmlHelper htmlHelper, string title, string field)
        {
            return DataGridInputColumn(htmlHelper, title, field, 0);
        }

        public static MvcHtmlString DataGridInputColumn(this HtmlHelper htmlHelper, string title, string field, int width)
        {
            return DataGridInputColumn(htmlHelper, title, field, width, false, true);
        }

        public static MvcHtmlString DataGridInputColumn(this HtmlHelper htmlHelper, string title, string field, int width, bool sortable, bool visible)
        {
            return DataGridInputColumn(htmlHelper, title, field, width, sortable, visible, null);
        }

        public static MvcHtmlString DataGridInputColumn(this HtmlHelper htmlHelper, string title, string field, int width, bool sortable, bool visible, string style)
        {
            return DataGridTextColumn(htmlHelper, title, field, width, sortable, visible, style, true);
        }

        #region TextColumn
        public static MvcHtmlString DataGridTextColumn(this HtmlHelper htmlHelper, string title, string field)
        {
            return DataGridTextColumn(htmlHelper, title, field, 0);
        }

        public static MvcHtmlString DataGridTextColumn(this HtmlHelper htmlHelper, string title, string field, int width)
        {
            return DataGridTextColumn(htmlHelper, title, field, width, false, true);
        }

        public static MvcHtmlString DataGridTextColumn(this HtmlHelper htmlHelper, string title, string field, int width, bool sortable, bool visible)
        {
            return DataGridTextColumn(htmlHelper, title, field, width, sortable, visible, null);            
        }

        public static MvcHtmlString DataGridTextColumn(this HtmlHelper htmlHelper, string title, string field, int width, bool sortable, bool visible, string style)
        {
            return DataGridTextColumn(htmlHelper, title, field, width, sortable, visible, style, false);
        }
        #endregion

        private static MvcHtmlString DataGridTextColumn(this HtmlHelper htmlHelper, string title, string field, int width, bool sortable, bool visible, string style, bool editable)
        {
            StringBuilder builder = new StringBuilder();
            if(editable)
            {
                builder.AppendLine("                        editable:{");
                builder.AppendLine("                            type: 'text',");
                builder.AppendLine($"                            title: '{title}'");
                builder.AppendLine("                        }");
            }
            return htmlHelper.DataGridColumn(title, field, width, sortable, visible, style, builder.ToString());
        }
    }
}