using MVCLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLinq.Controllers
{
    public class TelefoneController : Controller
    {
        // GET: Telefone
        static IList<Telefone> Telefone = new List<Telefone>()
        {
            new Telefone {Id=1, DDD=82, NumeroTelefone=999990009},
            new Telefone {Id=2, DDD=82, NumeroTelefone=988550555},
            new Telefone {Id=3, DDD=82, NumeroTelefone=987996655}
        };
        // GET: Telefone
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Telefone tel)
        {
            tel.Id = Telefone.Select(t => t.Id).Max() + 1;
            Telefone.Add(tel);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(Telefone.Where(t => t.Id == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Telefone tel)
        {
            Telefone.Remove(Telefone.Where(t => t.Id == tel.Id).First());
            Telefone.Add(tel);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(Telefone.Where(t => t.Id == id).First());
        }

        public ActionResult Delete(long id)
        {
            return View(Telefone.Where(t => t.Id == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(Telefone tel)
        {
            Telefone.Remove(Telefone.Where(t => t.Id == tel.Id).First());
            return RedirectToAction("Index");
        }
    }
}