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
            return View();
        }

        public ActionResult Novo()
        {
            string[] listGenero = { "Masculino", "Feminino", "Outro" };
            string[] listEstado = { "Solteiro", "Casado", "Outro" };

            ViewBag.ListGenero = new SelectList(listGenero);
            ViewBag.ListeEstado = new SelectList(listEstado);

            return View();
        }
    }
}