using JJLab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JJLab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
       

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListProducts()
        {

            List<Products> products = new List<Products>();

            var defaultProduct = new Products();
            products.Add(new Products { ProdName = "Jammers", ProdID = 1, ProdDescription = "Really cool shoes", ProdPrice = 33.23M, ProdQuantity = 42});
            products.Add(new Products { ProdName = "Speeder", ProdID = 2, ProdDescription = "Crazy fast car", ProdPrice = 10938.00M, ProdQuantity = 2});
            products.Add(new Products { ProdName = "Up-n-Down", ProdID = 3, ProdDescription = "Just a yo-yo!", ProdPrice = 3.99M, ProdQuantity = 20});
            products.Add(new Products { ProdName = "Soaker Pop", ProdID = 4, ProdDescription = "A rather nice squirt gun", ProdPrice = 19.99M, ProdQuantity = 73});
            products.Add(new Products { ProdName = "Floaty", ProdID = 5, ProdDescription = "A boat for a river cruise", ProdPrice = 9082.25M, ProdQuantity = 8});
            return View(products);
        }

        
        public  ActionResult Edit(Products model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            
            return View("Index", model);
        }
    }
}