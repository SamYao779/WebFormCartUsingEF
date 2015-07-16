using DemoWebFormEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebFormEntity
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<Product> GetProduct()
        {
            WebFormDbContext db = new WebFormDbContext();
            List<Product> model = null;
            int id = int.Parse(Request.QueryString["id"]);
            if (id > 0)
            {
                model = db.Products.Where(p => p.CategoryId == id).ToList();
            }
            return model;
        }
    }
}