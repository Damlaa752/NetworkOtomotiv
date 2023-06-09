using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetworkOtomotiv.Core.Utils;
using NetworkOtomotiv.DAL.Abstract;
using NetworkOtomotiv.DAL.Concrete;
using NetworkOtomotiv.DAL.Context;
using NetworkOtomotiv.Entity.Model.Entity;

namespace NetworkOtomotiv.Core.Controllers
{
    public class CarController : Controller
    {
        private readonly NetOtoDbContext db;
        private readonly ICarDAL _carDAL;
        private readonly IBrandDAL _brandDAL;
        private readonly IBodyTypeDAL _bodyTypeDAL;
        // private readonly IBodyTypeDAL _bodyTypeDAL;

        public CarController(ICarDAL carDAL, IBrandDAL brandDAL, IBodyTypeDAL bodyTypeDAL, NetOtoDbContext db) //, IBodyTypeDAL bodyTypeDAL
        {
            _carDAL = carDAL;
            _brandDAL = brandDAL;
            _bodyTypeDAL = bodyTypeDAL;
            this.db = db;
            //_bodyTypeDAL = bodyTypeDAL;
        }
        public IActionResult Index()
        {
            //  var car = db.Cars.Include(p => p.BodyType).ToList();
            //  return View(car);
            return View(_carDAL.GetAll());
        }
        public IActionResult Details(int id)
        {
            var model = _brandDAL.Get(id);
            return View(model);
        }
        //  [Authorize(Roles = "Admin, Create")]
        public IActionResult Create()
        {
            ViewData["BodyType"] = new SelectList(_bodyTypeDAL.GetAll(), "Id", "Name");
            ViewData["Brand"] = new SelectList(_brandDAL.GetAll(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Car car, [Bind("Image")] IFormFile image)
        {
            if (!ModelState.IsValid)
            {
                if (image != null)
                    car.Image = await FileHelper.FileLoaderAsync(image);
                _carDAL.Add(car);
                return RedirectToAction("Index");
            }
            return View();
        }
        // public IActionResult Edit(int id) => View(_carDAL.Get(id));

        [HttpPost]
        // public IActionResult Edit(Car car)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         _carDAL.Update(car);
        //         return RedirectToAction("Index");
        //     }
        //     return View(car);
        // }
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var model = _carDAL.GetAll().Find(i => i.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            ViewBag.BodyTypeId = new SelectList(_bodyTypeDAL.GetAll(), "Id", "Name");
            ViewBag.BrandId = new SelectList(_brandDAL.GetAll(), "Id", "Name");
            return View(model);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Car collection, IFormFile? Image, bool? resmiSil)
        {
            try
            {
                if (resmiSil is not null && resmiSil == true)
                {
                    FileHelper.FileRemover(collection.Image);
                    collection.Image = "";
                }
                if (Image is not null)
                {
                    collection.Image = await FileHelper.FileLoaderAsync(Image);
                }
                _carDAL.Update(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            ViewBag.CategoryId = new SelectList(_bodyTypeDAL.GetAll(), "Id", "Name");
            ViewBag.BrandId = new SelectList(_brandDAL.GetAll(), "Id", "Name");
            return View();
        }

        public IActionResult Delete(int id) => View(_carDAL.Get(id));

        [HttpPost]
        public IActionResult Delete(Car car, IFormFile image)
        {
            return View();
        }
    }
}
