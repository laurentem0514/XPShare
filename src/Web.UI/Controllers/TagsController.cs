using System;
using Microsoft.AspNetCore.Mvc;
using XPShare.Domain.Tags;
using XPShare.Web.UI.Models.Tags;

namespace XPShare.Web.UI.Controllers
{
    [Route("tags")]
    public class TagsController : Controller
    {
        private ITagRepository _tagRepository { get; set; }

        public TagsController(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var tags = _tagRepository.GetAll();
            return View(tags);
        }

        [HttpGet("{id}")]
        public IActionResult Details(Guid id)
        {
            var tag = _tagRepository.Get(id);
            return View(tag);
        }

        [HttpGet("{id}/delete")]
        public IActionResult Delete(Guid id)
        {
            _tagRepository.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            var model = new CreateTagForm();
            return View(model);
        }

        [HttpPost("create")]
        public IActionResult Create(CreateTagForm form)
        {
            var tag = new Tag { Name = form.Name };
            _tagRepository.Add(tag);

            return RedirectToAction("Details", new { id = tag.Id });
        }

        [HttpGet("/api/tags/search")]
        public IActionResult Search(string text)
        {
            return Ok(_tagRepository.Search(text));
        }
    }
}