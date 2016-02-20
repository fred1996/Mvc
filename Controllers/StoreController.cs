using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        public string Browse(string genre)
        {
            ///用于处理用户向链接注入javascript代码和html代码
            string message = HttpUtility.HtmlEncode("Strore.Browse , Genre ="+genre);
            return message;
            //return "Hello from Store.Browse()";
        }
        public string Details(int id)
        {
            string message = HttpUtility.HtmlEncode("Strore.Details, ID="+id);
            return message;
            //return "Hello from Store.Details()";
        }
    }
}