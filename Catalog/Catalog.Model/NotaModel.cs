using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Model
{
    public class NotaModel
    {
        public int ID { get; set; }
        [Required]
        public int IDElev { get; set; }
        [Required]
        public int IDMaterieClasa { get; set; }
        [Required]
        public int? Nota { get; set; }
        [Required]
        public DateTime DataNota { get; set; }
    }
}
