using PISistemaResponsivo.Infraestrutura.Dao;
using PISistemaResponsivo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PISistemaResponsivo.Controllers
{
    public class ParoquiaController : Controller
    {
        // GET: Paroquia
        public ActionResult Index()
        {
            ViewBag.Menu = 1;
            return View();
        }

        // GET: Paroquia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Paroquia/Create
        public ActionResult Novo()
        {
            ViewBag.Menu = 1;
            return View();
        }

        // POST: Paroquia/Create
        [HttpPost]
        public ActionResult Novo(Paroquia paroquia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    new ParoquiaDao().Salvar(paroquia);
                    ViewBag.Menu = 1;
                    return RedirectToAction("Index");
                }
                ViewBag.Msg = "Cadastro realizado com sucesso!";
                ViewBag.Menu = 1;
                return View(paroquia);
            }
            catch
            {
                ViewBag.Menu = 1;
                return View(paroquia);
            }
        }

        // GET: Paroquia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Paroquia/Edit/5
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

        // GET: Paroquia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Paroquia/Delete/5
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
