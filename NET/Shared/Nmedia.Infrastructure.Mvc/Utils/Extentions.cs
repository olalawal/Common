using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Nmedia.Infrastructure.Mvc
{
    public static class Extentions
    {



        public static List<SelectListItem> AddFirstItemToSelectListItems(List<SelectListItem> list, string Item)
        {
            // List<SelectListItem> _list = list.ToList();
            list.Insert(0, new SelectListItem() { Value = "-1", Text = Item });
            return list;
        }


        public static SelectList AddFirstItemToSelectList(SelectList list)
        {
            List<SelectListItem> _list = list.ToList();
            _list.Insert(0, new SelectListItem() { Value = "-1", Text = "This Is First Item" });
            return new SelectList((IEnumerable<SelectListItem>)_list, "Value", "Text");
        }

        public static List<SelectListItem> ToSelectList<T>(
       this IEnumerable<T> enumerable,
       Func<T, string> text,
       Func<T, string> value,
       string defaultOption
       )
        {
            var items = enumerable.Select(x => new SelectListItem
            {
                Text = text(x),
                Value = value(x).ToString(),
                Selected = false
            }).ToList();

            //items.Insert(0, new SelectListItem
            //{
            //    Text = defaultOption,
            //    Value = "-1",
            //    Selected = true
            //});

            return items;
        }



        public class HttpContextFactory
        {
            private static HttpContextBase m_context;
            public static HttpContextBase Current
            {
                get
                {
                    if (m_context != null) return m_context;
                    if (HttpContext.Current == null)
                        throw new InvalidOperationException("HttpContext is not available");
                    return new HttpContextWrapper(HttpContext.Current);
                }
            }

            public static void SetCurrentContext(HttpContextBase context)
            {
                m_context = context;
            }
        }

    }
}
