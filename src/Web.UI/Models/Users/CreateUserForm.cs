using System.ComponentModel.DataAnnotations;

namespace XPShare.Web.UI.Models.Users
{
    public class CreateUserForm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string GravatarEmail { get; set; }
    }
}
