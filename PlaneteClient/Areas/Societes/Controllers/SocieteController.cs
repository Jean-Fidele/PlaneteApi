using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System;
using Newtonsoft.Json;
using Domain.Entites.Societes;

namespace PlaneteClientB.Areas.Societes.Controllers
{
    [Area("Societes")]
    public class SocieteController : Controller
    {
        // GET: SocieteController
        public async Task<ActionResult> Index()
        {
            var url = "https://localhost:7254/Societe";
            var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                throw new Exception();

            var SocieteJson = response.Content.ReadAsStringAsync().Result;
            var societes = JsonConvert.DeserializeObject<Facade.Societes.Societe.GetAll.Result> (SocieteJson);

            return View(societes.societeModels);
        }

        // GET: SocieteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SocieteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SocieteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SocieteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SocieteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SocieteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SocieteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
