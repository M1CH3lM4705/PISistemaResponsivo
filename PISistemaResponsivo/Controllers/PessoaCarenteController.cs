using PISistemaResponsivo.Infraestrutura.Context;
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
    public class PessoaCarenteController : Controller
    {
        private DataContext _db = new DataContext();
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
        public ActionResult Alterar(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var pCarente = new PessoaCarenteDao().Find(id);

            if(pCarente == null)
            {
                return HttpNotFound();
            }

            ViewBag.Menu = 1;
            return View(pCarente);
        }

        // POST: PessoaCarente/Edit/5
        [HttpPost]
        public ActionResult Altear(PessoaCarente pessoaCarente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    new PessoaCarenteDao().Alterar(pessoaCarente);
                    ViewBag.Menu = 1;
                    ViewBag.Msg = "Produto Altearado com sucesso!";
                    return RedirectToAction("Index");
                }
                ViewBag.Menu = 1;
                return View(pessoaCarente);
            }
            catch
            {
                ViewBag.Menu = 1;
                return View(pessoaCarente);
            }
        }

        // GET: PessoaCarente/Delete/5
        public ActionResult Excluir(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pCarente = new PessoaCarenteDao().Find(id);
            
            if(pCarente == null)
            {
                return HttpNotFound();
            }
            ViewBag.Menu = 1;
            return View(pCarente);
        }

        // POST: PessoaCarente/Delete/5
        [HttpPost]
        public ActionResult Exlcuir(int id)
        {
            try
            {
                new PessoaCarenteDao().Excluir(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
