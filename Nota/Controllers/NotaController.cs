using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Revisao.Models;

namespace Revisao.Controllers
{
    public class NotaController : Controller
    {
        // GET: Nota
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Incluir(Aluno a)
        {
            if (ModelState.IsValid)
            {
                Repositorio.InsertAluno(a);

                return RedirectToAction("Listar");
            }

            return View(a);
        }

        public ActionResult Listar()
        {
            var alunos = Repositorio.GetAlunos();

            return View(alunos);
        }
    }
}