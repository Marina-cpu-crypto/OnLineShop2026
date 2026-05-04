using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public IActionResult Catalog()
        {
            var users = userRepository.GetAll();
            return View(users);

            //User user = new User("Пользователь", "Первый", "example@email");
            ////var user = userRepository.TryGetById(id);
            //return View(user);
        }
    }
}
