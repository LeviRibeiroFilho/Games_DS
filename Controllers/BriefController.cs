using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PORFAVORFUNCIONA3.Models;

namespace PORFAVORFUNCIONA3.Controllers
{
    public class BriefController : Controller
    {
        // GET: Brief
        public ActionResult Index(){

                Jogo jogo = new Jogo();
                return View(jogo);
            }
         
        [HttpPost]

        public ActionResult Index(Jogo jogo){
            if (ModelState.IsValid) {
                return View("MostrarJogo", jogo);
            }

            return View(jogo);
        }
        
        public ActionResult MostrarJogo(Jogo jogo) {
            return View(jogo);
        }

 }}