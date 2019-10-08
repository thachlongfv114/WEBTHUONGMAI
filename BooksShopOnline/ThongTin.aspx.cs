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
    public partial class BookDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Sport> GetDetails([QueryString("BookID")] int? bookId)
        {
            var _db = new BooksShopOnline.Models.SportContext();
            IQueryable<Sport> query = _db.Sports;
            if (bookId.HasValue && bookId > 0)
            {
                query = query.Where(p => p.SportID == bookId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}