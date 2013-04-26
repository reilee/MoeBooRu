using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;

namespace MoeBooRu
{
    public partial class _Default : System.Web.UI.Page
    {
        private static string SITE_URL = "http://konachan.com/post.json";

        protected void Page_Load(object sender, EventArgs e)
        {
            Stream stream = null;
            try
            {
                // Get response json string
                HttpWebRequest request = WebRequest.Create(SITE_URL) as HttpWebRequest;
                request.Method = "GET";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //string header = response.GetResponseHeader("");
                stream = response.GetResponseStream();

                // convert json to post class
                List<Post> posts = new List<Post>();
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Post>));
                posts = ser.ReadObject(stream) as List<Post>;

                this.Previews.DataSource = posts;
                this.Previews.DataBind();
            }
            finally
            {
                stream.Close();
            }
        }
    }
}
