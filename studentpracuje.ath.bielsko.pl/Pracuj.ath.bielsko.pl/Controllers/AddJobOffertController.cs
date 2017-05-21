using Pracuj.ath.bielsko.pl.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pracuj.ath.bielsko.pl.Controllers
{
    public class AddJobOffertController : Controller
    {
        // GET: AddJobOffert
        public ActionResult AddJobOffert()
        {
            var model = new AddJobOffertViewModel();
            List<string> JobCategories = new List<string>() {
               "Administracja biurowa",
               "Administracja Państwowa",
               "Agencje doradztwa personalnego",
               "Analiza",
               "Architektura",
               "Badania i rozwój",
               "Budownictwo/Geodezja",
               "Doradztwo/Konsulting",
               "Energetyka",
               "Farmaceutyka/Biotechnologia",
               "Finanse/Ekonomia",
               "Grafika/Kreacja artystyczna/Fotografia",
               "Hotelarstwo/Turystyka/Katering",
               "Human Resources",
               "Informatyka/Administracja",
               "Informatyka/Programowanie",
               "Inne",
               "Instalacja/Utrzymanie/Serwis",
               "Internet/E-Commerce",
               "Inżynieria/Konstrukcje/Technologia",
               "Kadra zarządzająca",
               "Kontrola jakości",
               "Księgowość/Audyt/Podatki",
               "Logistyka/Spedycja/Dystrybucja",
               "Marketing/Reklama/Public Relations",
               "Media/Sztuka/Rozrywka",
               "Nieruchomości/Budownictwo",
               "Obsługa klienta/Call Center",
               "Organizacje pozarządowe/Wolontariat",
               "Praca fizyczna",
               "Pracownik ochrony",
               "Praktyki",
               "Prawo",
               "Produkcja",
               "Projektowanie/Wdrażanie",
               "Rolnictwo/Ochrona środowiska",
               "Służba zdrowia",
               "Sport/Rekreacja",
               "Sprzedaż",
               "Staże",
               "Szkolenia/Edukacja",
               "Telekomunikacja",
               "Tłumaczenia",
               "Ubezpieczenia",
               "Zakupy"
            };
            model.JobCategory = new SelectList( "Value", "Text");
            List<SelectListItem> jobcategoryitem = new List<SelectListItem>();
            int i = 1;
            foreach (var item in JobCategories)
            {
                jobcategoryitem.Add(new SelectListItem { Text = item, Value = $"{i}" });
                i++;
            }
            model.JobCategory = new SelectList(jobcategoryitem, "Value", "Text");

            model.ContractType = new SelectList(
            new List<SelectListItem>
            {
                            new SelectListItem { Text = "Praca Stała", Value = "1"},
                            new SelectListItem { Text = "Praca Dodatkowa", Value = "2"},
                            new SelectListItem { Text = "Praca Sezonowa", Value = "3"},
                            new SelectListItem { Text = "Praca Tymczasowa", Value = "4"},
                            new SelectListItem { Text = "Umowa na okres próbny", Value = "5"},
                            new SelectListItem { Text = "Umowa o dzieło", Value = "6"},
                            new SelectListItem { Text = "Umowa zlecenia", Value = "7"},
                            new SelectListItem { Text = "Praktyka", Value = "8"},
                            new SelectListItem { Text = "Staż", Value = "9"},
                            new SelectListItem { Text = "Chałupnictwo", Value = "10"},
                            new SelectListItem { Text = "inna", Value = "11"},

            }, "Value", "Text");

            model.Experience = new SelectList(
            new List<SelectListItem>
            {
                            new SelectListItem { Text = "Brak", Value = "1"},
                            new SelectListItem { Text = "0.5 Roku", Value = "2"},
                            new SelectListItem { Text = "1 Rok", Value = "3"},
                            new SelectListItem { Text = "2 Lata", Value = "4"},
                            new SelectListItem { Text = "3 Lata", Value = "5"},
                            new SelectListItem { Text = "5 Lat", Value = "6"},
                            new SelectListItem { Text = "Ponad 5 Lat", Value = "7"},
            }, "Value", "Text");

            model.LvlOfEmployment = new SelectList(
            new List<SelectListItem>
            {
                            new SelectListItem { Text = "od 1 do 10 prac.", Value = "1"},
                            new SelectListItem { Text = "od 11 do 50 prac.", Value = "2"},
                            new SelectListItem { Text = "od 51 do 100 prac.", Value = "3"},
                            new SelectListItem { Text = "od 101 do 200 prac.", Value = "4"},
                            new SelectListItem { Text = "od 201 do 500 prac.", Value = "5"},
                            new SelectListItem { Text = "od 501 do 1000 prac.", Value = "6"},
                            new SelectListItem { Text = "Ponad 1000 prac.", Value = "7"},
            }, "Value", "Text");

            model.PostDuration = new SelectList(
            new List<SelectListItem>
            {
                            new SelectListItem { Text = "7 dni", Value = "1"},
                            new SelectListItem { Text = "14 dni", Value = "2"},
                            new SelectListItem { Text = "30 dni", Value = "3"},
            }, "Value", "Text");

            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult AddJobOffert(AddJobOffertViewModel model)
        {

            return View();
        }
    }
}