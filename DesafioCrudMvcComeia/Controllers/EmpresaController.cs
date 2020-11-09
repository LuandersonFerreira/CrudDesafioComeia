using DesafioCrudMvcComeia.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesafioCrudMvcComeia.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public ActionResult Index()
        {
            using (DbModels db = new DbModels())
            {
                return View(db.Empresas.ToList());
            }
            
        }

        // GET: Empresa/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels db = new DbModels())
            {
                return View(db.Empresas.Where(x=> x.Id == id).FirstOrDefault());
                
            }
            
        }

        // GET: Empresa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresa/Create
        [HttpPost]
        public ActionResult Create(Empresas empresas)
        {
            try
            {
                // TODO: Add insert logic here
                using (DbModels db = new DbModels())
                {
                    empresas.data_do_cadastro = DateTime.Now;
                    db.Empresas.Add(empresas);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empresa/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels db = new DbModels())
            {
                return View(db.Empresas.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Empresa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Empresas empresas)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModels db = new DbModels())
                {
                    db.Entry(empresas).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empresa/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels db = new DbModels())
            {
                return View(db.Empresas.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Empresa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Empresas empresas)
        {
            try
            {
                // TODO: Add delete logic here
                using (DbModels db = new DbModels())
                {
                    empresas = db.Empresas.Where(x => x.Id == id).FirstOrDefault();
                    db.Empresas.Remove(empresas);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
