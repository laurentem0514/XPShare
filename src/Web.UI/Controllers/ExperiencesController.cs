using System;
using Microsoft.AspNetCore.Mvc;
using XPShare.Domain.Experiences;

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
        public IActionResult CreateForm()
        {
            return View(new Experience());
        }

        [HttpPost("create")]
        public IActionResult Create(Experience experience)
        {
            _experienceRepository.Add(experience);

            return RedirectToAction("Details", new { id = experience.Id });
        }
    }
}