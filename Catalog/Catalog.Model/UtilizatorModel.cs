using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Model
{
    public class UtilizatorModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Camp obligatoriu")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Camp obligatoriu")]
        public int IDFunctie { get; set; }
        public string Functie { get; set; }

        [Display(Name = "Adresa de email")]
        [Required(ErrorMessage = "Camp obligatoriu")]
        [EmailAddress(ErrorMessage = "Adresa de email invalida")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Camp obligatoriu")]
        public string Prenume { get; set; }
        [Required(ErrorMessage = "Camp obligatoriu")]
        public string Nume { get; set; }
        [Display(Name = "Userul este parintele lui:")]
        public int? IDElev { get; set; }

        public IEnumerable<FunctieModel> Functii;
    }

}
