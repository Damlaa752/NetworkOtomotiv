using Microsoft.AspNetCore.Mvc;
using NetworkOtomotiv.DAL.Abstract;
using NetworkOtomotiv.DAL.Concrete;
using NetworkOtomotiv.Entity.Model.Entity;

namespace NetworkOtomotiv.Core.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandDAL _brandDAL;

        public BrandController(IBrandDAL brandDAL)
        {
            _brandDAL = brandDAL;
        }

        public IActionResult Index()
        {
            var model = _brandDAL.GetAll();
            return View(model);
        }
        public IActionResult Details(int id)
        {
            var model = _brandDAL.Get(id);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Brand brand)
        {
            if (!ModelState.IsValid)
            {
                _brandDAL.Add(brand);
                return RedirectToAction("Index");
            }
            return View(brand);
        }
        public IActionResult Edit(int id) => View(_brandDAL.Get(id));
        [HttpPost]
        public IActionResult Edit(Brand brand)
        {
            if (!ModelState.IsValid) //eğer veritabanına eklemeyip tekrar bu sayfayı reflesh yapıyorsa ! koymanız lazım ModelIsvalid hatası
            {
                _brandDAL.Update(brand);
                return RedirectToAction("Index");
            }
            return View(brand);
        }
        public IActionResult Delete(int id)
        {
            var model = _brandDAL.Get(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Brand brand)
        {
            _brandDAL.Delete(brand);
            return RedirectToAction("Index");
        }
    }
}
