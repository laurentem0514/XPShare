using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XPShare.Domain.Users;

namespace XPShare.Web.UI.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        private IUserRepository _userRepository { get; set; }

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var users = _userRepository.GetAll();
            return View(users);
        }

        [HttpGet("{id}")]
        public IActionResult Details(Guid id)
        {
            var user = _userRepository.Get(id);
            return View(user);
        }

        [HttpGet("{id}/delete")]
        public IActionResult Delete(Guid id)
        {
            _userRepository.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet("create")]
        public IActionResult CreateForm()
        {
            return View(new User());
        }

        [HttpPost("create")]
        public IActionResult Create(User user)
        {
            _userRepository.Add(user);

            return RedirectToAction("Details", new {id = user.Id });
        }
    }
}