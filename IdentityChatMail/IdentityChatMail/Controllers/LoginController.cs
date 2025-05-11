using IdentityChatMail.Entities;
using IdentityChatMail.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatMail.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _singInManager;
        public LoginController(SignInManager<AppUser> singInManager)
        {
            _singInManager = singInManager;
        }
        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserLogin(LoginViewModel model)
        {
            var result = await _singInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Inbox", "Message");
            }
            return View();
        }
    }
}
