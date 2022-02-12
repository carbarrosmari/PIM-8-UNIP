using MVCLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLinq.Controllers
{
    public class TipoController : Controller
    {
        // GET: Tipo
        static IList<Tipo> Tipo = new List<Tipo>()
        {
            new Tipo {Id=1, TipoTelefone="Celular"},
            new Tipo {Id=2, TipoTelefone="Residencial"},
            new Tipo {Id=3, TipoTelefone="Celular"}
        };
        // GET: Tipo
        public ActionResult Index()
        {
            return View(Tipo);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Tipo tipotel)
        {
            tipotel.Id = Tipo.Select(tt => tt.Id).Max() + 1;
            Tipo.Add(tipotel);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(Tipo.Where(tt => tt.Id == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Tipo tipotel)
        {
            Tipo.Remove(Tipo.Where(tt => tt.Id == tipotel.Id).First());
            Tipo.Add(tipotel);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(Tipo.Where(tt => tt.Id == id).First());
        }

        public ActionResult Delete(long id)
        {
            return View(Tipo.Where(tt => tt.Id == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(Tipo tipotel)
        {
            Tipo.Remove(Tipo.Where(tt => tt.Id == tipotel.Id).First());
            return RedirectToAction("Index");
        }
    }
}