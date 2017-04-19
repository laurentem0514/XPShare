using System;
using Microsoft.AspNetCore.Mvc;
using XPShare.Domain.Projects;
using XPShare.Web.UI.Models.Projects;

namespace XPShare.Web.UI.Controllers
{
    [Route("projects")]
    public class ProjectsController : Controller
    {
        private IProjectRepository _projectRepository { get; set; }

        public ProjectsController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var projects = _projectRepository.GetAll();
            return View(projects);
        }

        [HttpGet("{id}")]
        public IActionResult Details(Guid id)
        {
            var project = _projectRepository.Get(id);
            return View(project);
        }

        [HttpGet("{id}/delete")]
        public IActionResult Delete(Guid id)
        {
            _projectRepository.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            var model = new CreateProjectForm();
            return View(model);
        }

        [HttpPost("create")]
        public IActionResult Create(CreateProjectForm form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            var project = new Project { Name = form.Name };

            _projectRepository.Add(project);

            return RedirectToAction("Details", new { id = project.Id });
        }
    }
}