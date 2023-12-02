using GestionStagaires.Data;
using GestionStagaires.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GestionStagaires.Controllers
{
    [Authorize]
    public class StagiaireController : Controller
    {



        private readonly ApplicationDbContext _dbContext;

        public StagiaireController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult ListeStagiaires()
        {
            var listeStagiaires = _dbContext.Stagiaires.ToList();
            return View(listeStagiaires);
        }


        [HttpGet]
        public IActionResult CréerStagiaire()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CréerStagiaire(Stagiaire stagiaire )
        {
            _dbContext.Stagiaires.Add(stagiaire);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(ListeStagiaires));
        }

        [HttpGet]
        public IActionResult Afficher(int id)
        {
            var stag = _dbContext.Stagiaires.SingleOrDefault(i => i.Id == id);
            return View(stag);
        }

        [HttpGet]
        public IActionResult Supprimer(int id)
        {
            var stagaiare = _dbContext.Stagiaires.Find(id);
            return View(stagaiare);
        }

        [HttpPost]
        public IActionResult Supprimer(Stagiaire stagiare)
        {
            _dbContext.Stagiaires.Remove(stagiare);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(ListeStagiaires));
        }

        [HttpGet]
        public IActionResult Modifier(int id)
        {
            var stag = _dbContext.Stagiaires.SingleOrDefault(i => i.Id == id);
            return View(stag);
        }


        [HttpPost]
        public IActionResult Modifier(Stagiaire newStag)
        {
            var Oldstgaire = _dbContext.Stagiaires.Find(newStag.Id);

            if (Oldstgaire != null)
            {
                Oldstgaire.Nom = newStag.Nom;
                Oldstgaire.Prénom = newStag.Prénom;
                Oldstgaire.Téléphone = newStag.Téléphone;
                Oldstgaire.Entreprise = newStag.Entreprise;
                Oldstgaire.Sujet = newStag.Sujet;
                _dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(ListeStagiaires));
            

        }

    }
}
