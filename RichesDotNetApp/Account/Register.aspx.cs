﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RichesDotNetApp.Layer;

namespace RichesDotNetApp
{
    public partial class Account_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void StepNextButton_Click(object sender, EventArgs e)
        {
            ProfileDB profile = new ProfileDB();
            profile.InsertProfile(User.Identity.Name, FirstNameTextBox.Text, LastNameTextBox.Text, SSNTextBox.Text);
            //MyApp.ProductDB product = new MyApp.ProductDB();
            //product.InsertProduct(Description.Text);
        }
    }
}