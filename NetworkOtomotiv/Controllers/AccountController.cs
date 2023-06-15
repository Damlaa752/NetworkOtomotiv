﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetworkOtomotiv.Entity.Model.Identity;
using NetworkOtomotiv.Entity.Model.ViewModels;

namespace NetworkOtomotiv.Core.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly UserManager<Role> _roleManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, UserManager<Role> roleManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public IActionResult SignUp()
        {
            if (User.Identity.Name == null)
                return View();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {
            var user = new User(model.UserName)
            {
                Name = model.Name,
                Surname = model.SurName,
                Email = model.Email,
                Password = model.Password,
                PhoneNumber = model.Password
            };
            var result = await _userManager.CreateAsync(user, user.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn");
            }
            return View(model);
        }
        public IActionResult SignIn()
        {
            if (User.Identity.Name == null)
                return View();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async IActionResult SignIn(SignInViewModel model)
        {
            User user;
            if (model.UserNameOrEmail.Contains("@"))
                user = await _userManager.FindByEmailAsync(model.UserNameOrEmail);
            else
                user = await _userManager.FindByNameAsync(model.UserNameOrEmail);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }
        public async Task<IActionResult> SignOutAsync()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
