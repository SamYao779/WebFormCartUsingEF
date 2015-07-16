using DemoWebFormEntity.Logic;
using DemoWebFormEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebFormEntity
{
    public partial class ShoppingCartaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (CartAction act = new CartAction())
            {
                double carttotal = act.GetTotal();
                if (carttotal > 0)
                {
                    lblTotal.Text = string.Format("{0:c}", carttotal);
                }
                else
                {
                    lblTotalText.Text = "";
                    lblTotal.Text = "";
                    ShoppingcartTitle.InnerText = "Shopping Cart is Empty";
                }
            }
        }

        public List<CartItem> GetCart()
        {
            CartAction action = new CartAction();
            return action.GetCartItem();
        }
    }
}