using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public partial class _Default : System.Web.UI.Page
{
    public  static List<JObject> Bookmarked { get
        {
            //if(Session["bookmarks"] == null)
            //{
            //    Session["bookmarks"] = new List<JObject>();
            //}
            return HttpContext.Current.Session["bookmarks"] as List<JObject>;
        }

        set
        {
            value = HttpContext.Current.Session["bookmarks"] as List<JObject>;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static string BookmarkRepo(string obj)
    {
        try
        {

            var list = (List<Object>)HttpContext.Current.Session["bookmark"];
            if (obj == "Here")
            {
                return JsonConvert.SerializeObject(list);
            }
            var o = JsonConvert.DeserializeObject(obj);
            if (list == null)
            {
                list = new List<Object>();

            }
            else
            {
                if (list.Exists(x => (x as JObject)["id"].ToString() == (o as JObject)["id"].ToString()))
                {
                    var i = list.RemoveAll(x => (x as JObject)["id"].ToString() == (o as JObject)["id"].ToString());
                }
                //{
                //  //  list.Remove(x => x["id"] == (obj as JObject)["id"]);
                //}
            }
           
            list.Add(o);
            HttpContext.Current.Session["bookmark"] = list;
            //       HttpContext.Current.Response.Write(list.Count);// Bookmarked.Add(obj);
            return string.Empty;
        }
        catch (Exception ex)
        {

            return string.Empty;
        }
    }
}