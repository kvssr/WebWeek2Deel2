using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Week2Deel2.Models;

namespace Week2Deel2.Controllers
{
    public class HotelBoekingController : Controller
    {
        List<HotelBoeking> boekingen = new List<HotelBoeking>
            {
                new HotelBoeking(){Id = 1, Voornaam = "Henk", Achternaam = "Herrie", AantalPersonen = 4, Datum = new DateTime(2017, 10, 05)},
                new HotelBoeking(){Id = 2, Voornaam = "Bert", Achternaam = "Barends", AantalPersonen = 2, Datum = new DateTime(2017, 05, 05)},
                new HotelBoeking(){Id = 3, Voornaam = "Anna", Achternaam = "Arends", AantalPersonen = 2, Datum = new DateTime(2018, 07, 12)},
                new HotelBoeking(){Id = 4, Voornaam = "Berta", Achternaam = "Borstel", AantalPersonen = 6, Datum = new DateTime(2017, 09, 23)}
            };

        [HttpGet("HotelBoeking/Index", Name = "Index")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Verwerken(HotelBoeking h)
        {
            return View(h);
        }

        public IActionResult Wijzigen(HotelBoeking h)
        {
            return View(h);
        }

        [HttpGet("HotelBoeking/Create", Name = "Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet("HotelBoeking/Edit/{id}", Name ="Edit")]
        public IActionResult Edit(int id)
        {
            HotelBoeking h = boekingen.Where(b => b.Id == id).First();
            return View(h);
        }

        public IActionResult Overzicht()
        {
            return View(boekingen);
        }

        [HttpPost("HotelBoeking/Create", Name ="Create")]
        public IActionResult Create(HotelBoeking h)
        {
            return RedirectToAction("Verwerken", h);
        }

        [HttpPost("HotelBoeking/Edit", Name = "Wijzigen")]
        public IActionResult Edit(HotelBoeking h)
        {
            return RedirectToAction("Wijzigen", h);
        }
    }
}