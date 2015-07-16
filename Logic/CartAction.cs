using DemoWebFormEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebFormEntity.Logic
{
    public class CartAction : IDisposable
    {
        public string ShoppingCartId { get; set; }

        WebFormDbContext db = new WebFormDbContext();

        public const string SessionCart = "Cart";


        /// <summary>
        /// Tạo Session cho CartId
        /// </summary>
        /// <returns></returns>
        public string GetCartid()
        {
            if (HttpContext.Current.Session[SessionCart] == null)
            {
                // Tạo Session bằng tên của UserName
                // Nếu User đã đăng nhập
                if (!string.IsNullOrEmpty(HttpContext.Current.User.Identity.Name))
                {
                    // Thì Session = tên UserName
                    HttpContext.Current.Session[SessionCart] = HttpContext.Current.User.Identity.Name;
                }
                else // Nếu chưa đăng nhập 
                {
                    // Thì tạo Session = chuỗi ngẫu nhiên
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[SessionCart] = tempCartId.ToString();
                }
            }
            return HttpContext.Current.Session[SessionCart].ToString();
        }

        public void AddToCart(int Id)
        {
            ShoppingCartId = GetCartid();

            var cartitem = db.CartItems.SingleOrDefault(p => p.CartId == ShoppingCartId && p.ProductId == Id);

            if (cartitem == null)
            {
                cartitem = new CartItem
                {
                    ItemId = Guid.NewGuid().ToString(),
                    CartId = GetCartid(),
                    Quantity = 1,
                    CreateDate = DateTime.Now,
                    Product = db.Products.SingleOrDefault(p => p.Id == Id),
                    ProductId = Id
                };
                db.CartItems.Add(cartitem);
            }
            else
            {
                cartitem.Quantity++;
            }
            db.SaveChanges();
        }

        public void Dispose()
        {
            if(db != null)
            {
                db.Dispose();
                db = null;
            }
        }

        public List<CartItem> GetCartItem()
        {
            ShoppingCartId = GetCartid();
            return db.CartItems.Where(p => p.CartId == ShoppingCartId).ToList();
        }

        /// <summary>
        /// Tính tổng tiền đơn hàng
        /// </summary>
        /// <returns></returns>
        public double GetTotal()
        {
            ShoppingCartId = GetCartid();

            var model = db.CartItems.Where(p => p.CartId == ShoppingCartId);

            double tolal = 0;
            if(model.Any())
            {
                tolal = model.Select(p => p.Quantity * p.Product.UnitPrice).Sum();
            }
            return tolal;
        }
    }
}