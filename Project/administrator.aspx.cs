using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class administrator : System.Web.UI.Page
    {
        // Connect database on load
        protected void Page_Load(object sender, EventArgs e)
        {
            DB.Connect();
        }

        // GridView Button command
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            List<string> lst;
            string str = null;
            string index = null;
            int intIndex;

            // Checks if CommandName "cmd" had been call (could be more then one button in a raw) 
            if (e.CommandName == "cmd") 
            {
                intIndex = Convert.ToInt32(e.CommandArgument) + 1;
                index = "" + intIndex;

                lst = DB.UserLookUp(index);
                foreach (string s in lst) 
                {
                    str += " | " + s ;
                }
    
                lblRow.Text = str;
            }
        }

        protected void SubmitBtn_Click(Object sender, EventArgs e)
        {
            string str2 = null;
            List<string> lst2;
            string index = DropDownList.SelectedItem.Text;

            lst2 = DB.UserLookUp(index);
            foreach (string s in lst2)
            {
                str2 += " | " + s;
            }
            Label1.Text = str2;

        }
        // Go Back to Button - Disconnect database on exit
        protected void GoBack(object sender, EventArgs e)
        {
            DB.Disconnect();
            Response.Redirect("Login.aspx");
        }


    }
}