using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMIOC;
using IHRMBLL;
using HRMModel;
using Newtonsoft.Json;
namespace HRMUI.Controllers
{
    public class TestController : Controller
    {
        ICarBLL icb = IocContanier.CreateCar_BLL();
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FillTable()
        {
            List<CarModel> list = icb.QueryAll();
            return Content(JsonConvert.SerializeObject(list));
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Test/Edit/5
        public ActionResult Edit(int id)
        {
            CarModel c = new CarModel()
            {
                Id = id
            };
            //List<CarModel> list = icb.SelectByx();
            return View();
        }

        // POST: Test/Edit/5
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

        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}
