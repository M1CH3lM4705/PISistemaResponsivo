using PISistemaResponsivo.Infraestrutura.Dao;
using PISistemaResponsivo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PISistemaResponsivo.Controllers
{
    public class PessoaCarenteController : Controller
    {
        // GET: PessoaCarente
        public ActionResult Index()
        {
            ViewBag.Menu = 1;
            return View();
        }

        // GET: PessoaCarente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PessoaCarente/Create
        public ActionResult Novo()
        {
            string[] listGenero = { "Masculino", "Feminino", "Outro" };
            ViewBag.Menu = 1;
            ViewBag.Genero = listGenero;
            return View();
        }

        // POST: PessoaCarente/Create
        [HttpPost]
        public ActionResult Novo(PessoaCarente pCarente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    new PessoaCarenteDao().Salvar(pCarente);
                    ViewBag.Menu = 1;
                    return RedirectToAction("Index");
                }
                ViewBag.Msg = "Cadastro realizado com sucesso!";
                ViewBag.Menu = 1;
                return View(pCarente);
            }
            catch
            {
                ViewBag.Menu = 1;
                return View();
            }
        }

        // GET: PessoaCarente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PessoaCarente/Edit/5
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

        // GET: PessoaCarente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PessoaCarente/Delete/5
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
