using MvcProva6.Context;
using MvcProva6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProva6.Controllers
{
    public class AlunoController : Controller
    {
        private readonly Contexto db = new Contexto();

        // GET: Aluno
        public ActionResult Index()
        {
            return View(db.alunos.ToList());
        }

        [HttpGet]
        public ActionResult Create() 
        {
            return View();    
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AlunoModel aluna)
        {
            if (ModelState.IsValid)
            {
                db.alunos.Add(aluna);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(aluna);
        }
    }
}