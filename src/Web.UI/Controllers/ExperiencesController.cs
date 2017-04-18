using System;
using Microsoft.AspNetCore.Mvc;
using XPShare.Domain.Experiences;
using XPShare.Web.UI.Models.Experiences;
using XPShare.Domain.Users;

namespace XPShare.Web.UI.Controllers
{
    [Route("experiences")]
    public class ExperiencesController : Controller
    {
        private IExperienceRepository _experienceRepository { get; set; }

        private IUserRepository _userRepository { get; set; }

        public ExperiencesController(IExperienceRepository experienceRepository, IUserRepository userRepository)
        {
            _experienceRepository = experienceRepository;
            _userRepository = userRepository;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var users = _experienceRepository.GetAll();
            return View(users);
        }

        [HttpGet("{id}")]
        public IActionResult Details(Guid id)
        {
            var user = _experienceRepository.Get(id);
            return View(user);
        }

        [HttpGet("{id}/delete")]
        public IActionResult Delete(Guid id)
        {
            _experienceRepository.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            var model = new CreateExperienceForm();
            Populate(model);
            return View(model);
        }

        [HttpPost("create")]
        public IActionResult Create(CreateExperienceForm form)
        {
            if (!ModelState.IsValid)
            {
                Populate(form);
                return View(form);
            }
            var experience = new Experience { Description = form.Description };

            _experienceRepository.Add(experience);

            return RedirectToAction("Details", new { id = experience.Id });
        }

        private void Populate(CreateExperienceForm form)
        {
            var users = _userRepository.GetAll();
            form.Users = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(users, nameof(Domain.Users.User.Id), nameof(Domain.Users.User.Name));
        }
    }
}