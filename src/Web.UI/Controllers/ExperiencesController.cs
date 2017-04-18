using System;
using Microsoft.AspNetCore.Mvc;
using XPShare.Domain.Experiences;
using XPShare.Web.UI.Models.Experiences;

namespace XPShare.Web.UI.Controllers
{
    [Route("experiences")]
    public class ExperiencesController : Controller
    {
        private IExperienceRepository _experienceRepository { get; set; }

        public ExperiencesController(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
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
            return View(new CreateExperienceForm());
        }

        [HttpPost("create")]
        public IActionResult Create(CreateExperienceForm form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            var experience = new Experience { Description = form.Description };

            _experienceRepository.Add(experience);

            return RedirectToAction("Details", new { id = experience.Id });
        }
    }
}