using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XPShare.Domain.Users;

namespace XPShare.Web.UI.Controllers
{
    public class UsersController : Controller
    {
        private IUserRepository _userRepository { get; set; }

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            var users = _userRepository.GetAll();
            return View(users);
        }
    }
}