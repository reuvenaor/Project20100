using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Load Welcome meesage
            string name = (string)Application["Name"];
            string family = (string)Application["Family"];
            Response.Write("Welcome " + name + "\t" + family );
        }

        // Show Withdraw menu Button
        protected void Withdraw(object sender, EventArgs e)
        {
            pnlWithraw.Visible = true;
        }
        // Show Deposit menu Button
        protected void Deposit(object sender, EventArgs e)
        {
            pnlDeposit.Visible = true;
        }
        // Confirm Withdraw Button
        protected void ConfirmWithdraw(object sender, EventArgs e)
        {
            int balance = 0;
            int amount = Convert.ToInt32(txtWithdraw.Text);
            string idx = (string)Application["Idx"];
            // Calls DB methods to 
            DB.Connect();
            balance = DB.Action(idx, amount,'-');                      
            DB.Disconnect();
            //
            lblWithdrawSum.Text = "You withdrawed: " + amount + " your Blanace is: " + balance;
        }
        // Confirm Deposit Button
        protected void ConfirmDeposit(object sender, EventArgs e)
        {
            int balance = 0;
            int amount = Convert.ToInt32(txtDeposit.Text);
            string idx = (string)Application["Idx"];
            // Calls DB methods to
            DB.Connect();
            balance = DB.Action(idx, amount,'+');
            DB.Disconnect();
            // Calls DB methods to
            lblDepositSum.Text = "You deposired: " + amount + " your Blanace is: " + balance;
        }
        // Go Back to Button
        protected void GoBack(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}