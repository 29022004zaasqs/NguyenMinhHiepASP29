using LvhBaiDanhGiaGiuaKy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LvhBaiDanhGiaGiuaKy.Controllers
{
    public class LvhProductController : Controller
    {
        private static List<LvhProduct> lvhProducts = new List<LvhProduct>()
        {
            new LvhProduct(){LvhId=106,LvhFullName="Lê Vinh Huy",LvhImage="1234",LvhQuantity=10,LvhPrice=1000000,LvhIsActive=true},
            new LvhProduct(){LvhId=1,LvhFullName="Đỗ Trọng Thạo",LvhImage="1235",LvhQuantity=11,LvhPrice=2000000,LvhIsActive=true},

        };
        // GET: LvhProduct
        public ActionResult LvhIndex()
        {
            return View(lvhProducts);
        }
        public ActionResult LvhCreate()
        {
            var lvhModel =new LvhProduct();
            return View(lvhModel);
        }
        [HttpPost]
        public ActionResult LvhCreate(LvhProduct lvhProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(lvhProduct);
            }
            lvhProducts.Add(lvhProduct);
            return RedirectToAction("LvhIndex");
        }
        public ActionResult LvhEdit(int id)
        {
            var product = lvhProducts.Find(p => p.LvhId == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        public ActionResult LvhDetails(int id)
        {
            var product = lvhProducts.Find(p => p.LvhId == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LvhEdit(LvhProduct lvhProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(lvhProduct);
            }

            var product = lvhProducts.Find(p => p.LvhId == lvhProduct.LvhId);
            if (product == null)
            {
                return HttpNotFound();
            }

            // Cập nhật các giá trị
            product.LvhFullName = lvhProduct.LvhFullName;
            product.LvhImage = lvhProduct.LvhImage;
            product.LvhQuantity = lvhProduct.LvhQuantity;
            product.LvhPrice = lvhProduct.LvhPrice;
            product.LvhIsActive = lvhProduct.LvhIsActive;

            return RedirectToAction("LvhIndex");
        }
        
    }
}
