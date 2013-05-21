using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Json/

        public ActionResult Index(string url, string limit, string page, string tags)
        {
            url = Sites.KONACHAN + "?";
            if (!string.IsNullOrWhiteSpace(limit))
            {
                url += "limit=" + limit + "&";
            }
            if (!string.IsNullOrWhiteSpace(page))
            {
                url += "page=" + page + "&";
            }
            if (!string.IsNullOrWhiteSpace(tags))
            {
                url += "tags=" + tags + "&";
            }
            string callback = "onLoadData";

            string postJson = string.Empty;
            try
            {
                // Get response json string
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Method = "GET";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                postJson = reader.ReadToEnd();
            }
            finally
            {
                
            }

            return JavaScript(string.Format("{0}({1});", callback, postJson));
        }
    }
}
