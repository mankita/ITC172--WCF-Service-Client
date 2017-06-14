using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewGrants : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CommunityAssistServRef.Community_AssistServiceClient sc = 
            new CommunityAssistServRef.Community_AssistServiceClient();

        var userId = (int) Session["userKey"];

        var grants = sc.ViewGrants(userId);

        GridView1.DataSource = grants;
        GridView1.DataBind();

    }
}