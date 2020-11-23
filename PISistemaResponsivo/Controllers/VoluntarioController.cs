using PISistemaResponsivo.Infraestrutura.Dao;
using PISistemaResponsivo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PISistemaResponsivo.Controllers
{
    public class VoluntarioController : Controller
    {
        // GET: Voluntario
        public ActionResult Index()
        {
            ViewBag.Menu = 1;
            return View();
        }

        // GET: Voluntario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Voluntario/Create
        public ActionResult Novo()
        {
            ViewBag.Menu = 1;
            return View();
        }

        // POST: Voluntario/Create
        [HttpPost]
        public ActionResult Novo(Voluntario voluntario)
        {
            try
            {
                // TODO: Add insert logic here
                if(ModelState.IsValid)
                {
                    new VoluntarioDao().Salvar(voluntario);
                    ViewBag.Menu = 1;
                    return RedirectToAction("Index");
                }
                ViewBag.Msg = "Cadastro realizado com sucesso!";
                ViewBag.Menu = 1;
                return View(voluntario);
            }
            catch
            {
                ViewBag.Menu = 1;
                return View(voluntario);
            }
        }

        // GET: Voluntario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Voluntario/Edit/5
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

        // GET: Voluntario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Voluntario/Delete/5
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
