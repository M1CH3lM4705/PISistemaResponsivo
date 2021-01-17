using PISistemaResponsivo.Infraestrutura.Dao;
using PISistemaResponsivo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PISistemaResponsivo.Controllers
{
    public class ParoquiaController : Controller
    {
        // GET: Paroquia
        public ActionResult Index()
        {
            var par = new ParoquiaDao().Listar();
            ViewBag.Menu = 1;
            return View(par);
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
        public ActionResult Alterar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var paroquia = new ParoquiaDao().Find(id);

            if (paroquia == null)
            {
                return HttpNotFound();
            }

            ViewBag.Menu = 1;
            return View(paroquia);
        }

        // POST: PessoaCarente/Edit/5
        [HttpPost]
        public ActionResult Altear(Paroquia paroquia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    new ParoquiaDao().Alterar(paroquia);
                    ViewBag.Menu = 1;
                    ViewBag.Msg = "Produto Altearado com sucesso!";
                    return RedirectToAction("Index");
                }
                ViewBag.Menu = 1;
                return View(paroquia);
            }
            catch
            {
                ViewBag.Menu = 1;
                return View(paroquia);
            }
        }

        // GET: PessoaCarente/Delete/5
        public ActionResult Excluir(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var paroquia = new ParoquiaDao().Buscar(id);

            if (paroquia == null)
            {
                return HttpNotFound();
            }
            ViewBag.Menu = 1;
            new ParoquiaDao().Excluir(id);

            return RedirectToAction("Index");
        }

        // POST: PessoaCarente/Delete/5
        [HttpPost]
        public ActionResult Exlcuir(int id)
        {
            try
            {
                new ParoquiaDao().Excluir(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
