using NmhBaiDanhGiaGiuaKy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NmhBaiDanhGiaGiuaKy.Controllers
{
    public class NmhProductController : Controller
    {
        private static List<NmhProduct> nmhProducts = new List<NmhProduct>()
        {
            new NmhProduct(){NmhId=106,NmhFullName="Lê Vinh Huy",NmhImage="1234",NmhQuantity=10,NmhPrice=1000000,NmhIsActive=true},
            new NmhProduct(){NmhId=1,NmhFullName="Đỗ Trọng Thạo",NmhImage="1235",NmhQuantity=11,NmhPrice=2000000,NmhIsActive=true},

        };
        // GET: NmhProduct
        public ActionResult NmhIndex()
        {
            return View(nmhProducts);
        }
        public ActionResult NmhCreate()
        {
            var nmhModel = new NmhProduct();
            return View(nmhModel);
        }
        [HttpPost]
        public ActionResult NmhCreate(NmhProduct nmhProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(nmhProduct);
            }
            nmhProducts.Add(nmhProduct);
            return RedirectToAction("NmhIndex");
        }
        public ActionResult NmhEdit(int id)
        {
            var product = nmhProducts.Find(p => p.NmhId == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        public ActionResult NmhDetails(int id)
        {
            var product = nmhProducts.Find(p => p.NmhId == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmhEdit(NmhProduct nmhProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(nmhProduct);
            }

            var product = nmhProducts.Find(p => p.NmhId == nmhProduct.NmhId);
            if (product == null)
            {
                return HttpNotFound();
            }

            // Cập nhật các giá trị
            product.NmhFullName = nmhProduct.NmhFullName;
            product.NmhImage = nmhProduct.NmhImage;
            product.NmhQuantity = nmhProduct.NmhQuantity;
            product.NmhPrice = nmhProduct.NmhPrice;
            product.NmhIsActive = nmhProduct.NmhIsActive;

            return RedirectToAction("NmhIndex");
        }
    }
}
