using MVCLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLinq.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        static IList<Pessoa> Pessoa = new List<Pessoa>()
        {
            new Pessoa {Id=1, Nome="Julia Maria dos Santos", Cpf=10236512597},
            new Pessoa {Id=2, Nome="Clarice Lispector", Cpf=10536516596},
            new Pessoa {Id=3, Nome="Machado de Assis", Cpf=103536916896}
        };
        // GET: Pessoa
        public ActionResult Index()
        {
            return View(Pessoa);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Pessoa people)
        {
            people.Id = Pessoa.Select(p => p.Id).Max() + 1;
            Pessoa.Add(people);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(Pessoa.Where(p => p.Id == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Pessoa people)
        {
            Pessoa.Remove(Pessoa.Where(p => p.Id == people.Id).First());
            Pessoa.Add(people);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(Pessoa.Where(p => p.Id == id).First());
        }

        public ActionResult Delete(long id)
        {
            return View(Pessoa.Where(p => p.Id == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(Pessoa people)
        {
            Pessoa.Remove(Pessoa.Where(p => p.Id == people.Id).First());
            return RedirectToAction("Index");
        }
    }
}