using System.ComponentModel.DataAnnotations;

namespace XPShare.Web.UI.Models.Projects
{
    public class CreateProjectForm
    {
        [Required]
        public string Name { get; set; }
    }
}
