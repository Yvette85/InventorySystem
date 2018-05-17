//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using InventorySystem11.DataAccessLayer;
//using InventorySystem11.Models;

//namespace InventorySystem11.Controllers
//{
//    public class ViewModelsController : Controller
//    {
//        private IEnumerable<SelectListItem> GetAllStates()
//        {

//            List<Product> list = db.Products.ToList();
          
//            IEnumerable<SelectListItem> slItem = from s in db.Products
//                                                 select new SelectListItem
//                                                 {
//                                                     Selected = s.Id.ToString() == "Active",
//                                                     //Text = s.State,
//                                                     //Value = s.State.ToString()
//                                                 };
//            return slItem;
//        }



//        private StorageContext db = new StorageContext();

//        // GET: ViewModels
//        public ActionResult Index()
            
//        {
//            var app = new Product
//            {

//                States = GetAllStates()
//            };
//            return View(db.ViewModels.ToList());
//        }

//        // GET: ViewModels/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ViewModel viewModel = db.ViewModels.Find(id);
//            if (viewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(viewModel);
//        }

//        // GET: ViewModels/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: ViewModels/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,Name,Price,Category,Shelf,Count,Description")] ViewModel viewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.ViewModels.Add(viewModel);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(viewModel);
//        }

//        // GET: ViewModels/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ViewModel viewModel = db.ViewModels.Find(id);
//            if (viewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(viewModel);
//        }

//        // POST: ViewModels/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,Name,Price,Category,Shelf,Count,Description")] ViewModel viewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(viewModel).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(viewModel);
//        }

//        // GET: ViewModels/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ViewModel viewModel = db.ViewModels.Find(id);
//            if (viewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(viewModel);
//        }

//        // POST: ViewModels/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            ViewModel viewModel = db.ViewModels.Find(id);
//            db.ViewModels.Remove(viewModel);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
