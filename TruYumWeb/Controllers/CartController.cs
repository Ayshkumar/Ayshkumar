using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TruYumWeb.Models;

namespace TruYumWeb.Controllers
{
    public class CartController : Controller
    {
        private static truYumContext db;

        public CartController(truYumContext _db)
        {
            db = _db;
        }
        // GET: Cart
        public ActionResult Index()
        {

            var obj=from value in db.Carts
                    join menu in db.MenuItems
                    on value.MenuItemId equals menu.Id
                    select menu;

            return View(obj);
        }
        public ActionResult Details()
        {
            var obj = from value in db.Carts
                      join menu in db.MenuItems
                      on value.MenuItemId equals menu.Id
                      select menu;
            return View(obj);
        }



        // POST: CartController/Delete/5

        /*
           [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                var obj1 = from value in db.Carts
                          join menu in db.MenuItems
                          on value.MenuItemId equals menu.Id
                          select value.Id;
                var obj = db.Carts.Find(obj1);
                db.Carts.Remove(obj);
                db.SaveChanges();
                return RedirectToAction(nameof(Details));
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }
        */


    }
}
