﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        // Go Back to Button
        protected void GoBack(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}