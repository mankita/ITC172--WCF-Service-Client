using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RequestGrant : System.Web.UI.Page
{
    CommunityAssistServRef.GrantType[] grantTypes;
    protected void Page_Load(object sender, EventArgs e)
    {
        CommunityAssistServRef.Community_AssistServiceClient sc =
            new CommunityAssistServRef.Community_AssistServiceClient();

        grantTypes = sc.GetGrantTypes();

        List<string> grantNames = new List<string>();

        foreach(var gt in grantTypes)
        {
            grantNames.Add(gt.GrantTypeName);
        }

        if (!Page.IsPostBack)
        {
            DropDownList1.DataSource = grantNames;
            DropDownList1.DataBind();
        }
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string selectedGrant = DropDownList1.SelectedValue;
        int selectedGrantId = 1;
        foreach(var gt in grantTypes)
        {
            if(selectedGrant.Equals(gt.GrantTypeName))
            {
                selectedGrantId = gt.GrantTypeKey;
                break;
            }
        }

        decimal grantAmount = decimal.Parse(GrantAmountTextBox.Text);
        string grantExplanation = ExplainationTextBox.Text;

        CommunityAssistServRef.Community_AssistServiceClient sc =
            new CommunityAssistServRef.Community_AssistServiceClient();
        int personId = ((int)Session["userKey"]);
        sc.RequestGrant(selectedGrantId, grantExplanation, grantAmount, personId);

        ResultLabel.Text = "Grant requested suceesfully" + personId; ;
    }
}