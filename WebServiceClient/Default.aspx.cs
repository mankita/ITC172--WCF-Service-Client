using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        CommunityAssistServRef.Community_AssistServiceClient sc =
            new CommunityAssistServRef.Community_AssistServiceClient();
        int result = sc.Login(UserTextBox.Text, PasswordTextBox.Text);

        if (result != 0)
        {
            Session["userKey"] = result;
            ResultLabel.Text = "Welcome" + result;
        }
        else
        {
            ResultLabel.Text = "Invalid login";
        }

    }

    protected void RegisterButton_Click(object sender, EventArgs e)
    {
       
    }






}