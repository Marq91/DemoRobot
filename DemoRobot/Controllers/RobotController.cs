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
    public class RobotController : Controller
    {
        private DemoRobotEntities1 db = new DemoRobotEntities1();

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

        // GET: Robot/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Robot/Create
        [HttpPost]
        public ActionResult Create(robot rob)
        {
            try
            {
                // TODO: Add insert logic here
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
        public ActionResult Delete(int? id)
        {
            if (id == null)
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

        // POST: Robot/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, robot rob)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    rob = db.robot.Find(id);
                    if (rob == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.robot.Remove(rob);
                        db.SaveChanges();
                    }

                    return RedirectToAction("Index");
                }
                return View(rob);
                
            }
            catch
            {
                return View(rob);
            }
        }
    }
}
