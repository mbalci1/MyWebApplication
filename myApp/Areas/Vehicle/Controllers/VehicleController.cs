using Aspose.Cells.Drawing;
using Microsoft.AspNetCore.Mvc;
using myApp.Controllers;
using myApp.Data;
using myApp.Models;
using System.Diagnostics;

namespace myApp.Areas.Vehicle.Controller
{
    [Area("Vehicle")]
    public class VehicleController: BaseController
    {
     
        private readonly ApplicationDbContext _applicationDbContext;

        public VehicleController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;

        }


        // GET: VehicleController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VehicleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VehicleController/Create
        public ActionResult Create()
        {
            Data.Vehicle vehicle = new();

            return View(vehicle);
        }

        // POST: VehicleController/Create
        [HttpPost]
        public ActionResult Create(Data.Vehicle vehicle)
        {
            try
            {
                Data.Vehicle entity = new Data.Vehicle();
                entity.Plate=vehicle.Plate;
                _applicationDbContext.Add(entity);
                _applicationDbContext.SaveChanges();    
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VehicleController/Edit/5
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

        // GET: VehicleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VehicleController/Delete/5
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
