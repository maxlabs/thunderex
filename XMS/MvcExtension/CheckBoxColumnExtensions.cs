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
    public static class CheckBoxColumnExtensions
    {
        public static MvcHtmlString DataGridCheckBoxColumn(this HtmlHelper htmlHelper)
        {
            return DataGridCheckBoxColumn(htmlHelper, "全选", "select", 25);
        }

        public static MvcHtmlString DataGridCheckBoxColumn(this HtmlHelper htmlHelper, int width)
        {
            return DataGridCheckBoxColumn(htmlHelper, "全选", "select", width);
        }

        public static MvcHtmlString DataGridCheckBoxColumn(this HtmlHelper htmlHelper, string title, string field)
        {
            return DataGridCheckBoxColumn(htmlHelper, title, field, 0);
        }

        public static MvcHtmlString DataGridCheckBoxColumn(this HtmlHelper htmlHelper, string title, string field, int width)
        {
            return DataGridCheckBoxColumn(htmlHelper, title, field, width, false, true);
        }

        public static MvcHtmlString DataGridCheckBoxColumn(this HtmlHelper htmlHelper, string title, string field, int width, bool sortable, bool visible)
        {
            return DataGridCheckBoxColumn(htmlHelper, title, field, width, sortable, visible, null);
        }

        public static MvcHtmlString DataGridCheckBoxColumn(this HtmlHelper htmlHelper, string title, string field, int width, bool sortable, bool visible, string style)
        {
            return DataGridCheckBoxColumn(htmlHelper, title, field, width, sortable, visible, style, true);
        }

        private static MvcHtmlString DataGridCheckBoxColumn(this HtmlHelper htmlHelper, string title, string field, int width, bool sortable, bool visible, string style, bool editable)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("checkbox: true,");
            builder.Append("align: 'center',");
            builder.Append("valign: 'middle',");
            return htmlHelper.DataGridColumn(title, field, width, sortable, visible, builder.ToString(), null);
        }
    }
}