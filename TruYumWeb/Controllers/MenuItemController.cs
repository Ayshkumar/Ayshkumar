using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TruYumWeb.Models;

namespace TruYumWeb.Controllers
{
    public class MenuItemController : Controller
    {
        private static truYumContext db;

        public MenuItemController(truYumContext _db)
        {
            db = _db;
        }
        // GET: MenuItemController

        public ActionResult Index()
        {
            return View(db.MenuItems.Where(e=>e.Active==true).ToList());
        }

        public void AddCartItem(int userId,int menuItemId)
        {
            Cart cart = new Cart();
            cart.UserId = userId;
            cart.MenuItemId = menuItemId;
            cart.Quantity= 1;
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public ActionResult AddToCart(int id)
        {
            try
            {
                AddCartItem(2, id);  
                return RedirectToAction("Index", "Cart");
            }
            catch
            {
                return View();
            }
        }

        
    }
}
