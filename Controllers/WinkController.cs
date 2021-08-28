using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PORFAVORFUNCIONA3.Models;

namespace PORFAVORFUNCIONA3.Controllers
{
    public class WinkController : Controller
    {
        // GET: Wink
        public ActionResult Index() {
            Funcionario funcionario = new Funcionario();
            return View(funcionario);
        }

        [HttpPost]
        public ActionResult Index(Funcionario funcionario) { 
            if (ModelState.IsValid) {
                return View("MostrarFuncionario", funcionario);
            }
            return View(funcionario);
        }

        public ActionResult MostrarFuncionario(Funcionario funcionario) {
            return View(funcionario);
        }
    }
}