using System.ComponentModel.DataAnnotations;

namespace XPShare.Web.UI.Models.Experiences
{
    public class CreateExperienceForm
    {
        [Required]
        public string Description { get; set; }
    }
}
