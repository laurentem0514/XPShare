using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace XPShare.Web.UI.Models.Experiences
{
    public class CreateExperienceForm
    {
        [Required]
        public string Description { get; set; }

        [Required(ErrorMessage ="User is required")]
        public string UserId { get; set; }

        public string Tags { get; set; }

        public SelectList Users;
    }
}
