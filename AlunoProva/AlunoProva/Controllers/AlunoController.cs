using AlunoProva.Context;
using AlunoProva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlunoProva.Controllers
{
    public class AlunoController : Controller
    {
        private readonly Contexto db = new Contexto();
        // GET: Aluno
        public ActionResult Index()
        {
            return View(db.alunos.ToList());
        }

        #region create
        [HttpGet]
        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Aluno alunos)
        {
            if (ModelState.IsValid)
            {
                db.alunos.Add(alunos);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(alunos);
        }
        #endregion
    }
}