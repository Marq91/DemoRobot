﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DemoRobot.Models;

namespace DemoRobot.Controllers
{
    public class RobotController : Controller
    {
        private DemoRobotEntities db = new DemoRobotEntities();

        // GET: Robot
        public ActionResult Index()
        {

            return View(db.robot.ToList());
        }

        // GET: Robot/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                robot rob = db.robot.Find(id);
                if (rob == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(rob);
                }
            }
        }

        //Lista Robots
        public List<robot> ObtenerRobot()
        {
            var ro = new robot();
            {
                ro.id_robot.ToString();
                ro.nombre_robot.ToString();
                ro.estado.ToString();
            };

            return new List<robot> { ro };
        }


        // GET: Robot/Create
        public ActionResult Create()
        {
            var sCombo = db.servidor
                            .OrderBy(c => (c.nombre_servidor))
                            .ToList();

            ViewBag.nombre_servidor = new SelectList(sCombo, "id_servidor", "nombre_servidor");

            return View();
        }

        // POST: Robot/Create
        [HttpPost]
        public ActionResult Create(robot rob)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.robot.Add(rob);
                    db.SaveChanges();
                    return RedirectToRoute("Tarea");
                    //return RedirectToAction("Create");
                }
                return View(rob);
                
            }
            catch
            {
                return View(rob);
            }
        }

        // GET: Robot/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                robot x = db.robot.Find(id);
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

        // POST: Robot/Edit/5
        [HttpPost]
        public ActionResult Edit(robot rob)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(rob).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(rob);
            }
            catch
            {
                return View(rob);
            }
        }

        // GET: Robot/Delete/5
        public ActionResult Delete(int id)
        {
            robot rob = db.robot.SingleOrDefault(c => c.id_robot == id);
            return View(rob);
            
        }

        // POST: Robot/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, robot model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model = db.robot.Find(id);
                    if (model == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.robot.Remove(model);
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
