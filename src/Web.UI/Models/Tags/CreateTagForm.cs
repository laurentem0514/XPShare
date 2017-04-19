using System.ComponentModel.DataAnnotations;

namespace XPShare.Web.UI.Models.Tags
{
    public class CreateTagForm
    {
        [Required]
        public string Name { get; set; }
    }
}
