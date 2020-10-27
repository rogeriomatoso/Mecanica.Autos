using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Mecanica.Autos.Dados.Entity.Context;
using Mecanica.Autos.Dominio;
using Mecanica.Autos.Web.ViewModels.CarroPasseio;

namespace Mecanica.Autos.Web.Controllers
{
    public class CarroPasseiosController : Controller
    {
        private AutosDbContext db = new AutosDbContext();

        // GET: CarroPasseios
        public ActionResult Index()
        {
            return View(Mapper.Map<List<CarroPasseio>,List<CarroPasseioIndexViewModel>> (db.CarroPasseios.ToList()));
        }

        // GET: CarroPasseios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarroPasseio carroPasseio = db.CarroPasseios.Find(id);
            if (carroPasseio == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<CarroPasseio, CarroPasseioIndexViewModel>(carroPasseio));
        }

        // GET: CarroPasseios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarroPasseios/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Modelo,Marca,Cor,Combustivel,Ano,RenavamUF")] CarroPasseioViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                CarroPasseio carroPasseio = Mapper.Map<CarroPasseioViewModel, CarroPasseio>(viewModel);
                db.CarroPasseios.Add(carroPasseio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: CarroPasseios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarroPasseio carroPasseio = db.CarroPasseios.Find(id);
            if (carroPasseio == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<CarroPasseio, CarroPasseioViewModel>(carroPasseio));
        }

        // POST: CarroPasseios/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Modelo,Marca,Cor,Combustivel,Ano,RenavamUF")] CarroPasseioViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                CarroPasseio carroPasseio = Mapper.Map<CarroPasseioViewModel, CarroPasseio>(viewModel);
                db.Entry(carroPasseio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: CarroPasseios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarroPasseio carroPasseio = db.CarroPasseios.Find(id);
            if (carroPasseio == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<CarroPasseio, CarroPasseioIndexViewModel>(carroPasseio));
        }

        // POST: CarroPasseios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarroPasseio carroPasseio = db.CarroPasseios.Find(id);
            db.CarroPasseios.Remove(carroPasseio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
