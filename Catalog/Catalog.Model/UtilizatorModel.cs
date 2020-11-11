using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Model
{
    public class UtilizatorModel
    {
        public int ID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public int IDFunctie { get; set; }
        public string Functie { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required]
        public string Prenume { get; set; }
        [Required]
        public string Nume { get; set; }
        [Display(Name = "Userul este parintele lui:")]
        public int? IDElev { get; set; }

        public IEnumerable<FunctieModel> Functii;
    }

}
