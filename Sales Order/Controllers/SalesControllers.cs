using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sales_Order.Data;
using Sales_Order.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales_Order.Controllers
{
    public class SalesControllers : Controller
    {
        private SalesDAL saleDAL = null;
        public SalesControllers()
        {
            saleDAL = new SalesDAL();

        }
        // GET: SalesControllers
        public ActionResult Index() 
        {
            IEnumerable<Sales> sales = saleDAL.GetAllSalesOrder();
            return View(sales);
        }

        public ActionResult Home()
        {
            IEnumerable<Sales> sales = saleDAL.GetAllSalesOrder();
            return View(sales);
        }

        public ActionResult About()
        {
            return View();
        }
        // GET: SalesControllers/Details/5
        public ActionResult Details(int ID)
        {
            Sales sale = saleDAL.GetSalesOrdersData(ID);
            return View(sale);
        }

        // GET: SalesControllers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalesControllers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sales sale)
        {
            saleDAL.AddSalesOrder(sale);
            return RedirectToAction(nameof(Index));
        }

        // GET: SalesControllers/Edit/5
        public ActionResult Edit(int ID)
        {
            Sales sale = saleDAL.GetSalesOrdersData(ID);
            return View(sale);
        }

        // POST: SalesControllers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Sales sale)
        {
            try
            {
                saleDAL.UpdateSalesOrder(sale);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SalesControllers/Delete/5
        public ActionResult Delete(int ID)
        {
            Sales sale = saleDAL.GetSalesOrdersData(ID);
            return View(sale);
        }

        // POST: SalesControllers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Sales sale)
        {
            Sales sales = sale;
            saleDAL.DeleteSalesOrder(sales.ID);
            return RedirectToAction(nameof(Index));
        }
    }
}
