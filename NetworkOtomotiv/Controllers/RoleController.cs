using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetworkOtomotiv.Entity.Model.Identity;

namespace NetworkOtomotiv.Core.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<Role> _roleManager;

        public RoleController(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }
        public IActionResult Create() => View();
        [HttpPost]
        public async Task<IActionResult> CreateAsync(Role damla)
        {
            var role = await _roleManager.FindByNameAsync(damla.Name);
            if (role == null)
            {
                var result = await _roleManager.CreateAsync(damla);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(role);
        }
        public async Task<IActionResult> EditAsync(int id)
        {
            var role = await _roleManager.FindByIdAsync($"{id}");
            return View(role);  
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Role damla)
        {
            var role = await _roleManager.FindByNameAsync($"{damla.Id}");
            role.Name=damla.Name;
            role.NormalizedName = damla.NormalizedName;
            var result = await _roleManager.UpdateAsync(damla);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View(damla);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var role = await _roleManager.FindByIdAsync($"{id}");
            if (role != null)
            {
                var result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
