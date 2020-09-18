using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using N00020449CRUD.Models;

namespace N00020449CRUD.Controllers
{
    public class CuentaController : Controller
    {
        private PersonaContexto _contexto;
        public CuentaController(PersonaContexto contexto)
        {
            _contexto = contexto;

        }
         [HttpGet]
        public ActionResult Index()
        {
            var cuentas = _contexto.Cuentas.ToList();
            return View("Index", cuentas);
                    }
        [HttpGet]
        public ActionResult Crear()
        {

            return View("Crear", new Cuenta());
        }
        //[HttpPost]
        public ActionResult Crear(Cuenta cuenta)
        {
            if (ModelState.IsValid)
            {
                _contexto.Cuentas.Add(cuenta);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
               
            }
            return View("Crear", cuenta);

        }
       
    }
}
