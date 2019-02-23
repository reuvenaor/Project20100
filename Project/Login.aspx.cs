using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        // OK Button method for 
        protected void Validation(object sender, EventArgs e)
        {
            List<string> lst = null;

            // Check info with database
            DB.Connect();
            string idx = DB.IsUser(txtName.Text, txtPass.Text);
            if (idx != null)
            {
                // Gets list of table Customers about the user
                lst = DB.UserLookUp(idx);
                
                // Insert into Page Application the User info 
                Application.Add("Idx", lst[0]);
                Application.Add("Name", lst[1]);
                Application.Add("Family", lst[2]);
                Application.Add("Address", lst[3]);
                Application.Add("CityNum", lst[4]);
                Application.Add("Phone", lst[5]);

                lst.Clear();                      
                DB.Disconnect();
                Response.Redirect("Welcome.aspx");
            }
            // Check if admin
            else if ( DB.IsAdmin(txtName.Text, txtPass.Text))
            {
                DB.Disconnect();
                Response.Redirect("administrator.aspx");
            }
            // User not exsit 
            else
            {
                DB.Disconnect();
                Response.Redirect("Error.aspx");
            }
        }
    }
}