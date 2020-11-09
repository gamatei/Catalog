using System.ComponentModel.DataAnnotations;

namespace Catalog.Model
{
    public class FunctieModel
    {
        public int ID { get; set; }
        [Required]
        public string Descriere { get; set; }
    }
}
