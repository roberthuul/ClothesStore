using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClothesStore.DatabaseContext;
using ClothesStore.Models;

namespace ClothesStore.Controllers
{
    public class ShoppingCartsController : Controller
    {
        private ClothesStoreDbContext db = new ClothesStoreDbContext();

        // GET: ShoppingCarts
        public ActionResult Index()
        {
            return View(db.ShoppingCarts.ToList());
        }

        // GET: ShoppingCarts/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoppingCart shoppingCart = db.ShoppingCarts.Find(id);
            if (shoppingCart == null)
            {
                return HttpNotFound();
            }
            return View(shoppingCart);
        }

       
       
       

        // GET: ShoppingCarts/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoppingCart shoppingCart = db.ShoppingCarts.Find(id);
            if (shoppingCart == null)
            {
                return HttpNotFound();
            }
            return View(shoppingCart);
        }

        // POST: ShoppingCarts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            ShoppingCart shoppingCart = db.ShoppingCarts.Find(id);
            db.ShoppingCarts.Remove(shoppingCart);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Pay

        public ActionResult Pay (Guid id)
        {
            ShoppingCart shoppingCart = db.ShoppingCarts.Find(id);
            shoppingCart.Paid = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
