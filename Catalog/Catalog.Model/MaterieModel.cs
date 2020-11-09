using System.ComponentModel.DataAnnotations;

namespace Catalog.Model
{
    public class MaterieModel
    {
        public int ID { get; set; }
        [Required]
        public string Nume { get; set; }
    }
}
