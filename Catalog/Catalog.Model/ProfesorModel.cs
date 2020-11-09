using System.ComponentModel.DataAnnotations;

namespace Catalog.Model
{
    public class ProfesorModel
    {
        public int ID { get; set; }
        [Required]
        public int IDUtilizator { get; set; }
        [Required]
        public string Detalii { get; set; }
        [Required]
        public int IDMaterie { get; set; }
    }
}
