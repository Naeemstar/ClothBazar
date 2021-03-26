using ClothBazar.Database;
using ClothBazar.Entities;
using ClothBazar.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.web.Controllers
{
    public class CategoryController : Controller
    {
        Categoryservices categoryservice = new Categoryservices();
        // GET: Category
        public ActionResult Index()
        {
            var cate = categoryservice.getcategory();
            return View(cate);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(category cate)
        {
         
            categoryservice.savecategory(cate);


            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var category = categoryservice.getsanglecategory(Id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(category cate)
        {

            categoryservice.updatecategory(cate);


            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var category = categoryservice.getsanglecategory(Id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(category category)
        {
             category = categoryservice.getsanglecategory(category.ID);
            categoryservice.deletecategory(category);


            return RedirectToAction("Index");
        }
    }
}