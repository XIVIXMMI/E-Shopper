using E_Shopper.Data;
using E_Shopper.Infrastructure;
using E_Shopper.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Shopper.Components
{
    public class CartWidget:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }

    }
}
