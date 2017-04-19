using System;
using Microsoft.AspNetCore.Mvc;
using XPShare.Domain.Users;
using XPShare.Web.UI.Models.Users;

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
        public IActionResult Create()
        {
            var model = new CreateUserForm();
            return View(model);
        }

        [HttpPost("create")]
        public IActionResult Create(CreateUserForm form)
        {
            var user = new User { Name = form.Name };
            _userRepository.Add(user);

            return RedirectToAction("Details", new {id = user.Id });
        }
    }
}