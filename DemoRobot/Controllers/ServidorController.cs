using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DemoRobot.Models;

namespace DemoRobot.Controllers
{
    public class ServidorController : Controller
    {
        private DemoRobotEntities db = new DemoRobotEntities();

        // GET: Servidor
        public ActionResult Index()
        {
            return View(db.servidor.ToList());
        }

        // GET: Servidor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public List<servidor> ObtenerServidor()
        {
            var ser = new servidor();
            {
                ser.id_servidor.ToString();
                ser.nombre_servidor.ToString();
                ser.ip_servidor.ToString();
                ser.cta_runner.ToString();
            };

            return new List<servidor> { ser };
        }

        // GET: Servidor/Create
        public ActionResult Create()
        {
            
            var sCombo = db.robot
                            .OrderBy(c => c.nombre_robot)
                            .ToList();

            ViewBag.nombre_robot = new SelectList(sCombo, "id_robot", "nombre_robot");

            return View();
        }

        // POST: Servidor/Create
        [HttpPost]
        public ActionResult Create(servidor ser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.servidor.Add(ser);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(ser);
            }
            catch
            {
                return View(ser);
            }
        }

        // GET: Servidor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                servidor x = db.servidor.Find(id);
                if (x == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(x);
                }
            }
        }

        // POST: Servidor/Edit/5
        [HttpPost]
        public ActionResult Edit(servidor ser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(ser).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(ser);
            }
            catch
            {
                return View(ser);
            }
        }

        // GET: Servidor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                servidor X = db.servidor.Find(id);
                if (X == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(X);
                }

            }
        }

        // POST: Servidor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, servidor model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model = db.servidor.Find(id);
                    if (model == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.servidor.Remove(model);
                        db.SaveChanges();
                    }

                    return RedirectToAction("Index");
                }
                return View(model);

            }
            catch
            {
                return View(model);
            }
        }
    }
}
