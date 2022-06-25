using DemoEntityFramework.Entities;
using DemoEntityFramework.Logic;
using DemoEntityFramework.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoEntityFramework.Web.Controllers
{
    public class ShipperController : Controller
    {
        //01:48:31
        // GET: Shipper
        public ActionResult Index()
        {
            ILogic<Shippers> logic = new ShipperLogic();
            var shippers = logic.GetAll();
            return View(shippers);
        }

        public ActionResult Listado()
        {
            ILogic<Shippers> logic = new ShipperLogic();
            var shippers = logic.GetAll();
            var modelo = new ShipperListadoModel
            {
                ListShippers = shippers,
                Cantidad = shippers.Count
            };
            return View(modelo);
        }

        public ActionResult Delete(int id)
        {
            ILogic<Shippers> logic = new ShipperLogic();
            var shipper = logic.GetById(id);
            return View(shipper);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ILogic<Shippers> logic = new ShipperLogic();
            logic.Delete(id);
            return RedirectToAction("Listado");
        }

        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Shippers shipp)
        {
            ILogic<Shippers> logic = new ShipperLogic();
            logic.Add(shipp);
            return RedirectToAction("Listado");
        }

        public ActionResult Edit(int id)
        {
            ILogic<Shippers> logic = new ShipperLogic();
            var shipp = logic.GetById(id);
            return View(shipp);
        }

        [HttpPost]
        public ActionResult Edit(Shippers shipp)
        {
            ILogic<Shippers> logic = new ShipperLogic();
            logic.Update(shipp);
            return RedirectToAction("Listado");
        }        
    }
}