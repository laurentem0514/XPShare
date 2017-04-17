using System;
using Microsoft.AspNetCore.Mvc;
using XPShare.Domain.Projects;

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
        public IActionResult CreateForm()
        {
            return View(new Project());
        }

        [HttpPost("create")]
        public IActionResult Create(Project project)
        {
            _projectRepository.Add(project);

            return RedirectToAction("Details", new { id = project.Id });
        }
    }
}