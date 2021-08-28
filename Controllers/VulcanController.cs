using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PORFAVORFUNCIONA3.Models;

namespace PORFAVORFUNCIONA3.Controllers
{
    public class VulcanController : Controller
    {
        // GET: Vulcan
        public ActionResult Index(){
            var cliente = new Cliente();

            return View(cliente);
        }

        [HttpPost]
        public ActionResult Index(Cliente cliente) {
            if (ModelState.IsValid) {
                return View("MostrarCliente", cliente);
            }
            return View(cliente);

        }

        public ActionResult MostrarJogo(Cliente cliente) {
            return View(cliente);
        }
        
}}