using Microsoft.AspNetCore.Mvc;
using Proyecto1.Models;
using Proyecto1.Services;

namespace Proyecto1.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userService.Lista();
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var usuarios = await _userService.Lista();

            var user = usuarios.FirstOrDefault(u =>
                u.Email == model.Email &&
                u.Password == model.Password &&
                u.Estado == true);

            if (user != null)
            {
                HttpContext.Session.SetString("Usuario", user.Email);

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Correo o contraseña incorrectos";
            return View();
        }
    }
}
