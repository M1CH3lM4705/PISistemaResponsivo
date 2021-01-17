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
    public class VoluntarioController : Controller
    {
        // GET: Voluntario
        public ActionResult Index()
        {
            ViewBag.Menu = 1;
            var vl = new VoluntarioDao().Listar();
            return View(vl);
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
        public ActionResult Alterar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var pCarente = new VoluntarioDao().Find(id);

            if (pCarente == null)
            {
                return HttpNotFound();
            }

            ViewBag.Menu = 1;
            return View(pCarente);
        }

        // POST: PessoaCarente/Edit/5
        [HttpPost]
        public ActionResult Altear(Voluntario voluntario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    new VoluntarioDao().Alterar(voluntario);
                    ViewBag.Menu = 1;
                    ViewBag.Msg = "Os dados foram altearado com sucesso!";
                    return RedirectToAction("Index");
                }
                ViewBag.Menu = 1;
                return View(voluntario);
            }
            catch
            {
                ViewBag.Menu = 1;
                return View(voluntario);
            }
        }

        // GET: PessoaCarente/Delete/5
        public ActionResult Excluir(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var voluntario = new VoluntarioDao().Buscar(id);

            if (voluntario == null)
            {
                return HttpNotFound();
            }
            new VoluntarioDao().Excluir(id);
            ViewBag.Menu = 1;
            return RedirectToAction("Index");
        }

            // POST: PessoaCarente/Delete/5
            [HttpPost]
        public ActionResult Exlcuir(int id)
        {
            try
            {
                new VoluntarioDao().Excluir(id);
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
