using MVCLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLinq.Controllers
{
    public class EnderecoController : Controller
    {
        static IList<Endereco> Endereco = new List<Endereco>()
        {
            new Endereco {Id=1, Logradouro="Av Juca Sampaio", Numero=10, Cep=57084530, Bairro="Feitosa", Cidade="Maceió", Estado="AL"},
            new Endereco {Id=2, Logradouro="Av Min. Mário Andreazza", Numero=20, Cep=57084880, Bairro="Vergel", Cidade="Maceió", Estado="AL"},
            new Endereco {Id=3, Logradouro="Rua B 37", Numero=17, Cep=57084260, Bairro="B. Bentes", Cidade="Maceió", Estado="AL"}
        };
        // GET: Endereco
        public ActionResult Index()
        {
            return View(Endereco);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Endereco end)
        {
            end.Id = Endereco.Select(e => e.Id).Max() + 1;
            Endereco.Add(end);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(Endereco.Where(e => e.Id == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Endereco end)
        {
            Endereco.Remove(Endereco.Where(e => e.Id == end.Id).First());
            Endereco.Add(end);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(Endereco.Where(e => e.Id == id).First());
        }

        public ActionResult Delete(long id)
        {
            return View(Endereco.Where(e => e.Id == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(Endereco end)
        {
            Endereco.Remove(Endereco.Where(e => e.Id == end.Id).First());
            return RedirectToAction("Index");
        }
    }
}