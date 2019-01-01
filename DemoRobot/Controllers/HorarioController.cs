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
        private DemoRobotEntities db = new DemoRobotEntities();

        // GET: Horario
        public ActionResult Index()
        {

            return View(db.horario.ToList());
        }

        // GET: Horario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                horario hor = db.horario.Find(id);
                if (hor == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(hor);
                }
            }
        }

        //Lista Horario
        public List<horario> ObtenerHorario()
        {
            var ta = new horario();
            {
                ta.id_horario.ToString();
                ta.hora_inicio.ToString();
                ta.hora_fin.ToString();
            };

            return new List<horario> { ta };
        }


        // GET: Horario/Create
        public ActionResult Create()
        {
            var sCombo = db.tarea
                            .OrderBy(c => (c.nombre_tarea))
                            .ToList();

            ViewBag.nombre_tarea = new SelectList(sCombo, "id_tarea", "nombre_tarea");
            
            return View();
        }

        // POST: Horario/Create
        [HttpPost]
        public ActionResult Create(horario model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.horario.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(model);
            }
            catch
            {
                return View(model);
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
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                horario X = db.horario.Find(id);
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

        // POST: Horario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, horario model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model = db.horario.Find(id);
                    if (model == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.horario.Remove(model);
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
