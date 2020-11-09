using System.ComponentModel.DataAnnotations;

namespace Catalog.Model
{
    public class ElevModel
    {
        public int ID { get; set; }
        [Required]
        public int IDUtilizator { get; set; }
        public string Utilizator { get; set; } // full name - pentru afisare in list
        [Required]
        public int IDClasa { get; set; }  // -> create / update
        public string Description { get; set; } // pentru afisare -> view
    }
}
