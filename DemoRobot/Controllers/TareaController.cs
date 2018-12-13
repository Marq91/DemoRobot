using DemoRobot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DemoRobot.Controllers
{
    public class TareaController : Controller
    {
        private DemoRobotEntities1 db = new DemoRobotEntities1();

        // GET: Tarea
        public ActionResult Index()
        {
            
            return View(db.tarea.ToList());
        }

        // GET: Tarea/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                tarea tar = db.tarea.Find(id);
                if (tar == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(tar);
                }
            }
        }

        public List<tarea> ObtenerTarea()
        {
            var ta = new tarea();
            {
                ta.id_tarea.ToString();
                ta.nombre_tarea.ToString();
            };

            return new List<tarea> { ta };
        }

        // GET: Tarea/Create
        public ActionResult Create()
        {
            //Llamar lista de id para realizar el enlace de tarea y robot
            //var sCombo = db.robot.Join(db.tarea, rob => rob.id_robot, hor => hor.id_robot, (rob, hor) => new { rob, hor }).ToList();

            var sCombo = db.robot
                            .OrderBy(c => c.nombre_robot)
                            .ToList();

            ViewBag.nombre_robot = new SelectList(sCombo, "id_robot", "nombre_robot");
            //ViewBag.nombre_robot = new SelectList(sCombo, "nombre_robot");

            //View va vacio
            return View();
        }

        // POST: Tarea/Create
        [HttpPost]
        public ActionResult Create(tarea tar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.tarea.Add(tar);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(tar);
            }
            catch
            {
                return View(tar);
            }
        }

        // GET: Tarea/Edit/5
        public ActionResult Edit(int id)
        {
            tarea tar = db.tarea.SingleOrDefault(c => c.id_tarea == id);
            var sCombo = db.robot
                            .OrderBy(c => c.nombre_robot)
                            .ToList();

            ViewBag.nombre_robot = new SelectList(sCombo, "id_robot", "nombre_robot", tar.nombre_tarea);

            return View(tar);
        }

        // POST: Tarea/Edit/5
        [HttpPost]
        public ActionResult Edit(tarea model)
        {
            try
            {
                tarea tar = db.tarea.SingleOrDefault(c => c.id_tarea == model.id_tarea);

                if (tar != null)
                {
                    tar.nombre_tarea = model.nombre_tarea;
                    tar.id_robot = model.id_robot;
                    db.SaveChanges();


                }
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: Tarea/Delete/5
        public ActionResult Delete(int id)
        {
            tarea tar = db.tarea.SingleOrDefault(c => c.id_tarea == id);
            return View(tar);
        }

        // POST: Tarea/Delete/5
        [HttpPost]
        public ActionResult Delete(tarea model)
        {
            try
            {
                tarea tar = db.tarea.SingleOrDefault(c => c.id_tarea == model.id_tarea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                tarea tar = db.tarea.SingleOrDefault(c => c.id_tarea == model.id_tarea);
                return View(tar);
            }
        }
    }
}
