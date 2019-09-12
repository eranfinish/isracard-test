using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
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
    public static void BookmarkRepo(object obj)
    {
        var list = (List<JObject>)HttpContext.Current.Session["bookmarks"];
        if(list == null)
        {
            list = new List<JObject>();

        }
        else
        {
            if(list.Exists(x=>x["id"] == (obj as JObject)["id"]))
            {
                list.Remove(x => x["id"] == (obj as JObject)["id"]);
            }
        }
        list.Add( obj as JObject);
       HttpContext.Current.Session["bookmarks"] = list;
        //       HttpContext.Current.Response.Write(list.Count);// Bookmarked.Add(obj);
    }

    [WebMethod]
    public static object GetBookmarks()
    {
        return Bookmarked;
    }
}