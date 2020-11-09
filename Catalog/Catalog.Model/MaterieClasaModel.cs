using System.ComponentModel.DataAnnotations;

namespace Catalog.Model
{
    public class MaterieClasaModel
    {
        public int ID { get; set; }
        [Required]
        public int IDClasa { get; set; }
        [Required]
        public int IDMaterie { get; set; }
        [Required]
        public int OreSaptamanal { get; set; }
        [Required]
        public int IDProfesor { get; set; }
    }
}
