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
    public class FormularioController : Controller
    {
        //DemoRobotsEntities proviene del webconfig
        private DemoRobotEntities1 db = new DemoRobotEntities1();

        private List<Formulario> formu;

        //Metodo Para crear listado horario
        public FormularioController() {

            formu = new List<Formulario>()
            {
                new Formulario()
                {
                    idhorario =1,
                    l1 =false, l2=true, l3=false , l4=true, l5=false,
                    ma1 =true, ma2=false, ma3=true, ma4=true, ma5=false,
                    mi1=true, mi2=true, mi3=false, mi4=false, mi5=false
                },
                //new horario()
                //{ idhorario =2, l1=true, l2=true},
                
            };
        }
        
        // GET: Formulario
        public ActionResult Index()
        {
            //var model = new horario();
            //model.l1 = false;
            //model.l2 = true;

            //return View(model);

            var model = new Formulario();
            model.nombre_robot = "";
            model.nombre_tarea = model.nombre_tarea;

            return View(model);

        }

        // GET: Formulario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Formulario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Formulario/Create
        [HttpPost]
        public ActionResult Create(robot rob)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.robot.Add(rob);
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

        // GET: Formulario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Formulario/Edit/5
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

        // GET: Formulario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Formulario/Delete/5
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
