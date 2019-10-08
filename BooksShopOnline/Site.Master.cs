using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BooksShopOnline.Logic;
using BooksShopOnline.Models;

namespace BooksShopOnline
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //protected void Page_PreRender(object sender, EventArgs e)
        //{
        //    using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
        //    {
        //        string cartStr = string.Format("Cart ({0})",
        //        usersShoppingCart.GetCount());
        //        t5.InnerText = cartStr;
        //    }
        //}
        public IQueryable<Category> GetCategories()
        {
            var _db = new BooksShopOnline.Models.SportContext();
            IQueryable<Category> query = _db.SportCategories;
            return query;
        }
        

    }
}