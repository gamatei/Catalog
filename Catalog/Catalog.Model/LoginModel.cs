using System.ComponentModel.DataAnnotations;

namespace Catalog.Model
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Parola { get; set; }
        public bool RememberMe { get; set; }
    }
}
