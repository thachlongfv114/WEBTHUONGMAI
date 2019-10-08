﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using BooksShopOnline.Logic;
namespace BooksShopOnline
{
    public partial class AddToCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["SportID"];
            int SportId;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out SportId))
            {
                using (ShoppingCartActions usersShoppingCart = new
                ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("loi, xin thu lai");
                throw new Exception("He thong loi, vui long thu lai !!.");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}