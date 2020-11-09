using System.ComponentModel.DataAnnotations;

namespace Catalog.Model
{
    public class ClasaModel
    {       
        public int ID { get; set; }
        [Required]
        public string Nume { get; set; }
        [Required]
        public int IDDiriginte { get; set; }
    }
}
