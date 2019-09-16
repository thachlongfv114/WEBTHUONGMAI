using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Specialized;
using System.Collections;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using BooksShopOnline.Models;
using BooksShopOnline.Logic;

namespace BooksShopOnline
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public List<CartItem> GetShoppingCartItems()
        {
            ShoppingCartActions actions = new ShoppingCartActions();
            return actions.GetCartItems();
        }
    }
}