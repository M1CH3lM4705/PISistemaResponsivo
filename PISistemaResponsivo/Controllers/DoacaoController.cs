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
    public class DoacaoController : Controller
    {
        // GET: Doacao
        public ActionResult Index()
        {
            var doa = new DoacaoDao().Listar();
            ViewBag.Menu = 1;
            return View(doa);
        }

        // GET: Doacao/Details/5

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
        public ActionResult Alterar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var doacao = new DoacaoDao().Find(id);

            if (doacao == null)
            {
                return HttpNotFound();
            }

            ViewBag.Menu = 1;
            return View(doacao);
        }

        // POST: PessoaCarente/Edit/5
        [HttpPost]
        public ActionResult Altear(Doacao doacao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    new DoacaoDao().Alterar(doacao);
                    ViewBag.Menu = 1;
                    ViewBag.Msg = "Produto Altearado com sucesso!";
                    return RedirectToAction("Index");
                }
                ViewBag.Menu = 1;
                return View(doacao);
            }
            catch
            {
                ViewBag.Menu = 1;
                return View(doacao);
            }
        }

        // GET: PessoaCarente/Delete/5
        public ActionResult Excluir(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var doacao = new DoacaoDao().Buscar(id);

            if (doacao == null)
            {
                return HttpNotFound();
            }
            new DoacaoDao().Excluir(id);
            ViewBag.Menu = 1;
            return RedirectToAction("Index");
        }

        // POST: PessoaCarente/Delete/5
        [HttpPost]
        public ActionResult Exlcuir(int id)
        {
            try
            {
                new DoacaoDao().Excluir(id);
                ViewBag.Menu = 1;
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Menu = 1;
                return View();
            }
        }
    }
}
