using PISistemaResponsivo.Infraestrutura.Dao;
using PISistemaResponsivo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PISistemaResponsivo.Controllers
{
    public class DoacaoController : Controller
    {
        // GET: Doacao
        public ActionResult Index()
        {
            ViewBag.Menu = 1;
            return View();
        }

        // GET: Doacao/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Menu = 1;
            return View();
        }

        // GET: Doacao/Create
        public ActionResult Novo()
        {
            ViewBag.PCarente = new PessoaCarenteDao().Listar();
            ViewBag.Voluntario = new VoluntarioDao().Listar();
            ViewBag.Paroquia = new ParoquiaDao().Listar();
            ViewBag.Menu = 1;
            return View();
        }

        // POST: Doacao/Create
        [HttpPost]
        public ActionResult Novo(Doacao doacao)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    new DoacaoDao().Salvar(doacao);
                    ViewBag.Menu = 1;
                    return RedirectToAction("Index");
                }
                ViewBag.Msg = "A doação foi realizada com sucesso!";
                ViewBag.Menu = 1;
                return View(doacao);
            }
            catch
            {
                ViewBag.Menu = 1;
                return View(doacao);
            }
        }

        // GET: Doacao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Doacao/Edit/5
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

        // GET: Doacao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Doacao/Delete/5
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
