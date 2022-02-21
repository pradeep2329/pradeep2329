using ProductClassLibrary;
using Products;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DressProduct.Controllers
{
    public class MVCProductController : Controller
    {
        public ActionResult AddNewProduct()
        {
            var con = new DataComponent();
            return View(new Product());
        }
        [HttpPost]
        public ActionResult AddNewProduct(Product product)
        {
            var con = new DataComponent();
            try
            {
                con.AddNewProduct(product);
                return View(new Product());
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                ViewBag.ErrorMessage = message;
                return View(new Product());
            }
        }
        public ActionResult UpdateProduct(string Code)
        {
            int DressCode = Convert.ToInt32(Code);
            var con = new DataComponent();
            try
            {
                var product = con.FindProduct(DressCode);
                return View(product);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            
            var con = new DataComponent();
            try
            {
                con.UpdateProduct(product);
                
                return RedirectToAction("GetAllProduct");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult DeleteProduct(string Code)
        {
            var con = new DataComponent();
            int DressCode = Convert.ToInt32(Code);
            try
            {
                con.DeleteProduct(DressCode);
                return RedirectToAction("GetAllProduct");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}