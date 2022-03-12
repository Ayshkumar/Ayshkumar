using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TruYumWeb.Models;

namespace TruYumWeb.Controllers
{
    public class MenuItemAdminController : Controller
    {
        private static truYumContext db;

        public MenuItemAdminController(truYumContext _db)
        {
            db = _db;
        }
        // GET: MenuItemAdminController
        public ActionResult Index()
        {
            return View(db.MenuItems.ToList());
        }

       

        // GET: MenuItemAdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuItemAdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MenuItem e)
        {
            db.MenuItems.Add(e);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: MenuItemAdminController/Edit/5
        public ActionResult Edit(int id)
        {
            MenuItem e = db.MenuItems.Find(id);
            return View(e);
        }

        // POST: MenuItemAdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MenuItem e)
        {
            db.Entry(e).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: MenuItemAdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MenuItemAdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
