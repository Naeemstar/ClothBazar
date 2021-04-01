using ClothBazar.Entities;
using ClothBazar.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.web.Controllers
{
    public class productController : Controller
    {
        productservices productservic = new productservices();
        // GET: product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult producttable(string search)
        {
            var products = productservic.getproduct();
            if(string.IsNullOrEmpty(search)==false)
            {
                products = products.Where(p => p.Name.Contains(search)).ToList();
            }
           
            return PartialView(products);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(product product)
        {
            productservic.saveproduct(product);
            return RedirectToAction("producttable");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var products = productservic.getsangleproduct(ID);
            return PartialView(products);
        }
        [HttpPost]
        public ActionResult Edit(product product)
        {
            productservic.updateproduct(product);
            return RedirectToAction("producttable");
        }
        [HttpPost]
        public ActionResult Delete(int ID)
        {
            productservic.deleteproduct(ID);
            return RedirectToAction("producttable");
        }
    }
}