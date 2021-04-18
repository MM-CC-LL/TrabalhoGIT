using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Git.Models;

namespace Trabalho_Git.Controllers
{
    public class HomeController : Controller
    {
        public static List<Agenda> Horarios = new List<Agenda>()
        {
                new Agenda
                {
                    Id = 1,
                    Horario = DateTime.Now.AddHours(2),
                    Description = "Dentista"
                },
                new Agenda
                {
                    Id = 2,
                    Horario = DateTime.Now.AddHours(3),
                    Description = "Psicologo"
                },
                new Agenda
                {
                    Id = 3,
                    Horario = DateTime.Now.AddHours(4),
                    Description = "Mercado"
                },
                new Agenda
                {
                    Id = 4,
                    Horario = DateTime.Now.AddHours(5),
                    Description = "Reuniao"
                }
            };

        public IActionResult Index()
        {
            return View(Horarios);
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(Agenda model)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var horario = Horarios.FirstOrDefault(x=> x.Id == id);
            return View(horario);
        }

        [HttpPost]
        public IActionResult Edit(Agenda model)
        {
            var horario = Horarios.FirstOrDefault(x => x.Id == model.Id);
            Horarios.Remove(horario);
            Horarios.Add(model);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var horario = Horarios.FirstOrDefault(x => x.Id == id);
            return View(horario);
        }

        [HttpPost]
        public IActionResult Delete(Agenda model)
        {
            var horario = Horarios.FirstOrDefault(x => x.Id == model.Id);
            Horarios.Remove(horario);
            return RedirectToAction(nameof(Index));
        }
    }
}
