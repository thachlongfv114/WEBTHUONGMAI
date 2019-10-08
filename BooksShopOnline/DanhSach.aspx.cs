using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BooksShopOnline.Models;
using System.Web.ModelBinding;

namespace BooksShopOnline
{
    public partial class BookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Sport> GetBooks([QueryString("id")] int? categoryId)
        {
            var _db = new BooksShopOnline.Models.SportContext();
            IQueryable<Sport> query = _db.Sports;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}