using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web;
using System.Web.Mvc;

using System.IO;
using ProductManagement.Models;
namespace ProductManagement.Controllers
{
    public class AddProductsController : Controller
    {
        private ProductsDBContext db = new ProductsDBContext();
        // GET: AddProducts
        public ActionResult Index()
        {
            var products = from e in db.Products
                            orderby e.ID
                            select e;
            return View(products);
        }

        // GET: AddProducts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddProducts/Create
        [HttpPost]
        public ActionResult Create(Products pro)
        //public ActionResult Create(Products pro, HttpPostedFileBase smallImage,HttpPostedFileBase largeImage)
        {
            try
            {
                //string path = Server.MapPath("~/SmallImage/");
                //if (!Directory.Exists(path))
                //{
                //    Directory.CreateDirectory(path);
                //}

                //if (smallImage != null)
                //{
                //    string fileName = Path.GetFileName(smallImage.FileName);
                //    smallImage.SaveAs(path + fileName);
                //    string converted = fileName.Replace('-', '+');
                //    converted = converted.Replace('_', '/');
                //    //ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
                //}
                //string path1 = Server.MapPath("~/LargeImage/");
                //if (!Directory.Exists(path1))
                //{
                //    Directory.CreateDirectory(path1);
                //}

                //if (largeImage != null)
                //{
                //    string fileName = Path.GetFileName(largeImage.FileName);
                //    largeImage.SaveAs(path + fileName);
                //    string converted = fileName.Replace('-', '+');
                //    converted = converted.Replace('_', '/');
                //    ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
                //}
                db.Products.Add(pro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddProducts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddProducts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddProducts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddProducts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
