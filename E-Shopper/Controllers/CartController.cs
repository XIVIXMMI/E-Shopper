using E_Shopper.Data;
using E_Shopper.Infrastructure;
using E_Shopper.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Shopper.Controllers
{
    public class CartController : Controller
    {
        public Cart? Cart { get; set; }
        public readonly ApplicationDbContext _context;
        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult AddToCart(int productId)
        {
            Product? product = _context.Products
                .FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(product, 1);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);
        }
    }
}
