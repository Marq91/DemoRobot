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
    public class Sis_operacionalController : Controller
    {
        private DemoRobotEntities db = new DemoRobotEntities();
        
        // GET: Sis_operacional
        public ActionResult Index()
        {
            return View(db.sistema_operacional.ToList());
        }

        // GET: Sis_operacional/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public List<sistema_operacional> ObtenerSisOperacional()
        {
            var sis = new sistema_operacional();
            {
                sis.id_sistema.ToString();
                sis.nombre_sis.ToString();
                sis.version.ToString();
                sis.credenciales.ToString();
                //sis.sys_robot.ToList().ToString();
            };

            return new List<sistema_operacional> { sis };
        }

        // GET: Sis_operacional/Create
        public ActionResult Create()
        {
            var sCombo = db.robot
                            .OrderBy(c => c.nombre_robot)
                            .ToList();

            ViewBag.nombre_robot = new SelectList(sCombo, "id_robot", "nombre_robot");

            return View();
        }

        // POST: Sis_operacional/Create
        [HttpPost]
        public ActionResult Create(sistema_operacional sis)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.sistema_operacional.Add(sis);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(sis);
            }
            catch
            {
                return View(sis);
            }
        }

        // GET: Sis_operacional/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                sistema_operacional x = db.sistema_operacional.Find(id);
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

        // POST: Sis_operacional/Edit/5
        [HttpPost]
        public ActionResult Edit(sistema_operacional sis)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(sis).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(sis);
            }
            catch
            {
                return View(sis);
            }
        }

        // GET: Sis_operacional/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                sistema_operacional sis = db.sistema_operacional.Find(id);
                if (sis == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(sis);
                }
            }
        }

        // POST: Sis_operacional/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, sistema_operacional sis)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    sis = db.sistema_operacional.Find(id);
                    if (sis == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.sistema_operacional.Remove(sis);
                        db.SaveChanges();
                    }

                    return RedirectToAction("Index");
                }
                return View(sis);

            }
            catch
            {
                return View(sis);
            }
        }
    }
}
