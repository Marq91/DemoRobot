using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using DemoRobot.Models;
using System.Net;

namespace DemoRobot.Controllers
{
    public class HorarioController : Controller
    {
        private DemoRobotEntities1 db = new DemoRobotEntities1();

        // GET: Horario
        public ActionResult Index()
        {

            return View(db.horario.ToList());
        }

        // GET: Horario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Horario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Horario/Create
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

        // GET: Horario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Horario/Edit/5
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

        // GET: Horario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Horario/Delete/5
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
