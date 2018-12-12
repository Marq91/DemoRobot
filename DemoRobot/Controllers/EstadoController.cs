using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoRobot.Models;

namespace DemoRobot.Controllers
{
    public class EstadoController : Controller
    {
        private DemoRobotEntities1 db = new DemoRobotEntities1();

        // GET: Estado
        public ActionResult Index()
        {
            //List<robot> robot_List = new List<robot>();
            //List<tarea> tarea_List = new List<tarea>();

            //Formulario finalItem = new Formulario();
            //finalItem.ListRobot = robot_List;
            //finalItem.ListTarea = tarea_List;

            //return View(finalItem);


            


            return View();
        }

        // GET: Estado/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Estado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estado/Create
        [HttpPost]
        public ActionResult Create(Formulario fModel)
        {
            try
            {

                //Create en base a consultas Select
                //Formulario finalItem = new Formulario();
                //finalItem.ListRobot = robot_List;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //Grabar datos en diferentes entidades mediante select en diferentes entidades en listas. 
        private void GrabaFomulario(Formulario fModelo)
        {
            //var fLista = db.robot.Where(c => c.id_robot == fModelo.id_robot)


        }


        // GET: Estado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estado/Edit/5
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

        // GET: Estado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estado/Delete/5
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
