using HW15;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Motorcycle.Controllers
{
    public class MotorcycleController : Controller
    {
        private readonly IMotorcycleRepository _motorcycleRepository;

        public MotorcycleController()
        {
            _motorcycleRepository = new FileMotorcycleRepository();
        }

        // GET: MotorcycleController
        public ActionResult Index()
        {
            var allMotorcycles = _motorcycleRepository.GetMotorcycles(); 

            return View(allMotorcycles);
        }

        // GET: MotorcycleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MotorcycleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MotorcycleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HW15.Motorcycle motorcycle)
        {
            if (motorcycle == null) return View();
            
            try
            {
                _motorcycleRepository.CreateMotorcycle(motorcycle);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MotorcycleController/Edit/5
        public ActionResult Edit(int id)
        {
            var motorcycle = _motorcycleRepository.GetMotorcycleByID(id);
            return View(motorcycle);
        }

        // POST: MotorcycleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, HW15.Motorcycle motorcycle)
        {
            try
            {
                _motorcycleRepository.UpdateMotorcycle(motorcycle);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MotorcycleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MotorcycleController/Delete/5
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
