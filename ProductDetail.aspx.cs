using DemoWebFormEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebFormEntity
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Product Detail()
        {
            WebFormDbContext db = new WebFormDbContext();
            int id = int.Parse(Request.QueryString["ProductId"]);
            Product model = null;
            if (id > 0)
            {
                model = db.Products.Single(p => p.Id == id);
            }
            else
            {
                model = null;
            }
            return model;
        }
    }
}