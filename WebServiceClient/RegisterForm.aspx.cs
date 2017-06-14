using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegisterForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void RegisterNewUserButton_Click(object sender, EventArgs e)
    {
        string lastname = LastNameTextBox.Text;
        string firstname = FirstNameTextBox.Text;
        string email = EmailTextBox.Text;
        string password = PasswordTextBox.Text;
        string apartment = ApartmentNumberTextBox.Text;
        string street = StreetTextBox.Text;
        string city = CityTextBox.Text;
        string state = StateTextBox.Text;
        string homephone = HomePhoneTextBox.Text;
        string workphone = WorkPhoneTextBox.Text;

        CommunityAssistServRef.Community_AssistServiceClient sc =
            new CommunityAssistServRef.Community_AssistServiceClient();

        sc.RegisterPerson(LastNameTextBox.Text, FirstNameTextBox.Text,
            EmailTextBox.Text, PasswordTextBox.Text,
            ApartmentNumberTextBox.Text, StreetTextBox.Text, CityTextBox.Text,
            StateTextBox.Text, ZipCodeTextBox.Text,
            HomePhoneTextBox.Text, WorkPhoneTextBox.Text);
        //CommunityAssistServRef.Person rev = new CommunityAssistServRef.Person();
        
        Response.Redirect("Default.aspx");
    }
}