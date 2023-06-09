using Microsoft.AspNetCore.Mvc;
using NetworkOtomotiv.DAL.Abstract;
using NetworkOtomotiv.Entity.Model.Entity;
using NetworkOtomotiv.Entity.Model.ViewModels;
using NetworkOtomotiv.Models;
using System.Diagnostics;

namespace NetworkOtomotiv.Core.Areas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBodyTypeDAL _bodyTypeDAL;
        private readonly ICarDAL _carDAL;

        public HomeController(IBodyTypeDAL bodyTypeDAL, ICarDAL carDAL)
        {
            this._bodyTypeDAL = bodyTypeDAL;
            this._carDAL = carDAL;
        }

        public IActionResult Index()
        {
            var models = new IndexViewModel()
            {
                BodyTypes = _bodyTypeDAL.GetAll(),
                Cars = _carDAL.GetAll()
            };
            return View(models);
        }
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}