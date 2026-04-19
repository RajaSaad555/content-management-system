using BusinessObject.Interface;
using Microsoft.AspNetCore.Mvc;
using Web.UI.Models;

namespace Web.UI.Controllers
{
    public class AccountController : Controller
    {
        // =====================================================
        // 🏗️ DEPENDENCY INJECTION
        // =====================================================
        // - Login Service handles authentication logic
        private readonly ILoginService _loginService;

        public AccountController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        // =====================================================
        // 🔐 1. LOGIN PAGE (GET)
        // =====================================================
        [HttpGet]
        public IActionResult Login()
        {
            // 📄 Initialize empty ViewModel for login form
            return View(new LoginViewModel());
        }

        // =====================================================
        // 🔐 2. LOGIN SUBMIT (POST)
        // =====================================================
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            // 🛡️ Validation check
            if (ModelState.IsValid)
            {
                // 🔍 Validate user credentials via service layer
                var userObject = await _loginService.ValidateUserAsync(model.Email, model.Password);

                if (userObject != null)
                {
                    // ✅ SUCCESS LOGIN FLOW

                    // 💾 Store user session
                    HttpContext.Session.SetString("UserID", userObject.Id.ToString());

                    // 🚀 Redirect to application home/dashboard
                    return Redirect("/Home/Index");
                }
                else
                {
                    // ❌ INVALID LOGIN
                    ModelState.AddModelError("", "Invalid email or password");
                }
            }

            // 🔁 If validation fails, return same view
            return View(model);
        }
    }
}