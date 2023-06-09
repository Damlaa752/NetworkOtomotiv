using Microsoft.AspNetCore.Mvc;
using NetworkOtomotiv.DAL.Abstract;
using NetworkOtomotiv.DAL.Concrete;
using NetworkOtomotiv.DAL.Context;
using NetworkOtomotiv.Entity.Model.Entity;

namespace NetworkOtomotiv.Core.Controllers
{
    public class BodyTypeController : Controller
    {
        private readonly IBodyTypeDAL _bodyTypeDAL;

        public BodyTypeController(IBodyTypeDAL bodyTypeDAL)
        {
            _bodyTypeDAL = bodyTypeDAL;
        }

        public IActionResult Index()
        {
            var model = _bodyTypeDAL.GetAll();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BodyType bodyType)
        {
            if (ModelState.IsValid)
            {
                _bodyTypeDAL.Add(bodyType);
                return RedirectToAction("Index");
            }
            return View(bodyType);
        }
        public IActionResult Details(int id)
        {
            var model = _bodyTypeDAL.Get(id);
            return View(model);
        }
        public IActionResult Edit(int id) => View(_bodyTypeDAL.Get(id));
        [HttpPost]
        public IActionResult Edit(BodyType bodyType)
        {
            if (ModelState.IsValid)
            {
                _bodyTypeDAL.Update(bodyType);
                return RedirectToAction("Index");
            }
            return View(bodyType);
        }
        [HttpGet] // yazılşmasına gerek yok default değer gettir.
        public IActionResult Delete(int id) => View(_bodyTypeDAL.Get(id));
        [HttpPost]
        public IActionResult Delete(BodyType bodyType) // postunda id olmaz model almamız lazm
        {
            var model = _bodyTypeDAL.Get(bodyType.Id);
            _bodyTypeDAL.Delete(model);
            return RedirectToAction("Index");
        }
    }
}

